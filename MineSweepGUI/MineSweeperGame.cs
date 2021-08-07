using MineSweeperConsole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweepGUI
{
    public partial class MineSweeperGame : Form
    {
        Stopwatch timer = new Stopwatch();

        public int gameLevel;
        public double secondsElapsed;

        static public int myBoardSize = 10;
        
        GameBoard gameBoard = new GameBoard(myBoardSize);
        public Button[,] boardGrid = new Button[myBoardSize, myBoardSize];

        // stores the rows and column of the buttons
        public Point[,] selectedButton = new Point[myBoardSize, myBoardSize];

        public MineSweeperGame(int gameDifficulty)
        {
            gameLevel = gameDifficulty;

            InitializeComponent();
            HiScores hs = new HiScores();
            hs.ShowDialog();



            //start timers
            timer.Start();
            tm_GameTime.Start();

            gameBoard.SetupLiveMembers(gameDifficulty); 
            for (int r = 0; r < myBoardSize -1; r++)
            {
                for (int c = 0; c < myBoardSize-1; c++)
                {
                    gameBoard.CalcLiveMembers(r, c);
                }
            }
           
            PopulateGrid(myBoardSize);
            
        }

        //This method is used to give a red boarder for the panel containing the timer. It is just for aesthetics.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.Red; 
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; 
            int thickness = 5;
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);

        }

        // Populates the buttonBoard with appropriate size buttionin a grid. 
        // Also gives mouse down click event for each button.
        private void PopulateGrid(int boardSize)
        {
            

            int buttonSize = pn_Board.Width / boardSize;
            pn_Board.Height = pn_Board.Width;

            for (int r = 0; r < boardSize; r++)
            {
                for (int c = 0; c < boardSize; c++)
                {
                    

                    boardGrid[r, c] = new Button();

                    boardGrid[r, c].Width = buttonSize;
                    boardGrid[r, c].Height = buttonSize;
                    boardGrid[r, c].BackgroundImage = Properties.Resources.facingDown;
                    boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;

                    boardGrid[r, c].MouseDown += Grid_Button_Click;
                    pn_Board.Controls.Add(boardGrid[r, c]);

                   

                    boardGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c);
                    
                    
                    boardGrid[r, c].Tag = r.ToString() + "|" + c.ToString();

                }
            }

        }

        // All button click event for grid. The right click plants flag and left click uncovers whats underneath.
        private void Grid_Button_Click(object sender, MouseEventArgs e)
        {
            Button clickedButton = (Button)sender;
                        
            
            // Plants Flag on a square without setting to active for use of the game
            if (e.Button == MouseButtons.Right)
            {
                clickedButton.BackgroundImage = Properties.Resources.flagged;
                clickedButton.BackgroundImageLayout = ImageLayout.Stretch;

            }
            // Reviels the grid button selected and gameplay occures based on the grids contents
            else if (e.Button == MouseButtons.Left)
            {
                int row = clickedButton.Location.X / (pn_Board.Width / myBoardSize);
                int col = clickedButton.Location.Y / (pn_Board.Width / myBoardSize);
                boardGrid[row, col].BackgroundImage = Properties.Resources._0ms;
                boardGrid[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                
                
                //sets the selected button / grid item active state to true
                gameBoard.grid[row, col].ActiveState = true;

                int liveNeighbors = gameBoard.grid[row,col].LiveNeighbors;


                UpdateBoard(false);

                if (liveNeighbors == 0)
                {
                    gameBoard.FloodFill(row,col);
                    UpdateBoard(false);
                }
                else if (liveNeighbors > 0 && liveNeighbors <= 8)
                {
                    UpdateBoard(false);
                }
                else
                {
                    boardGrid[row, col].BackgroundImage = Properties.Resources.covidBomb;
                    boardGrid[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                    GameOver();
                }
                IsWon();

            }

        }

        // In the event that a mine is clicked, this method clears the board
        private void GameOver()
        {
            for (int r = 0; r < myBoardSize; r++)
            {
                for (int c = 0; c < myBoardSize; c++)
                {
                    gameBoard.grid[r, c].ActiveState = true;

                }
            }

            UpdateBoard(true);

            EndGameLauncher(false);
            
        }
        
        
        // gets the elapsed time and whether won or lost
        // and sends it to the endGame Form which displays
        // it and options
        private void EndGameLauncher(bool winner)
        {
            timer.Stop();
            tm_GameTime.Stop();

            int endMin = (int)timer.Elapsed.TotalMinutes;
            int endSec = (int)timer.Elapsed.TotalSeconds;
            EndGame end = new EndGame(endMin, endSec, winner, gameLevel);
            
            end.Show();
        }

        // This method will check after each play if the game is won
        private void IsWon()
        {
            secondsElapsed = timer.ElapsedMilliseconds * 1000;
            int mines = 0;
            int nonmines = 0;

            for (int r = 0; r < myBoardSize; r++)
            {
                for (int c = 0; c < myBoardSize; c++)
                {
                    if (!gameBoard.grid[r, c].ActiveState && gameBoard.grid[r, c].IsLive)
                        mines++;
                    if (!gameBoard.grid[r, c].ActiveState && !gameBoard.grid[r, c].IsLive)
                    {
                        nonmines++;
                    }
                }
            }
           
            if(mines > 0 && nonmines == 0)
            {
                UpdateBoard(true);
                EndGameLauncher(true);
            }

        }

        /*
         * This method updates the board after each click so that the game cell buttons display the appropriate picture
         * indicating the number of live neighbores. In the event that the game is over and this method is being called,
         * All of the cell buttons display their live members.
         */
        private void UpdateBoard(bool gameOver)
        {
            for (int r = 0; r < myBoardSize; r++)
            {
                for (int c = 0; c < myBoardSize; c++)
                {
                    if(gameBoard.grid[r,c].ActiveState == true)
                    {
                        switch (gameBoard.grid[r, c].LiveNeighbors)
                        {
                            case 0:
                                boardGrid[r, c].BackgroundImage = Properties.Resources._0ms;
                                boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 1:
                                boardGrid[r, c].BackgroundImage = Properties.Resources._1;
                                boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 2:
                                boardGrid[r, c].BackgroundImage = Properties.Resources._2;
                                boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 3:
                                boardGrid[r, c].BackgroundImage = Properties.Resources._3;
                                boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 4:
                                boardGrid[r, c].BackgroundImage = Properties.Resources._4;
                                boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 5:
                                boardGrid[r, c].BackgroundImage = Properties.Resources._5;
                                boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 6:
                                boardGrid[r, c].BackgroundImage = Properties.Resources._6;
                                boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 7:
                                boardGrid[r, c].BackgroundImage = Properties.Resources._7;
                                boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 8:
                                boardGrid[r, c].BackgroundImage = Properties.Resources._8;
                                boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 9:
                                if (gameOver)
                                {
                                    boardGrid[r, c].BackgroundImage = Properties.Resources.covidBomb;
                                    boardGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                                }
                                break;
                            default :
                                break;
                        }
                    }
                    
                }
            }
        }


        // Timer Tick event updates the lalbel for the timer
        private void tm_Timer_Tick(object sender, EventArgs e)
        {
            
            lbl_Clock.Text = $"{timer.ElapsedMilliseconds / 1000}"; ;
        }

       
    }
}
