using System;
using System.Collections.Generic;
using System.Text;
using static MineSweeperConsole.GameCell;


/*
 * This is the GameBoard class for the MineSweeper Game. In this class, there are 3 properties,
 * the board size, the difficulty level, and a two-dimentional array that contains GameCell class objects.
 */
namespace MineSweeperConsole
{
    class GameBoard
    {

        /*
         * The constructor initializes the two dimentional array with gameCell objects based on the size of the board
         * given by the driver program.
        */
        public GameBoard(int boardSize)
        {
            this.BoardSize = boardSize;

            grid = new GameCell[boardSize, boardSize];

            for(int row = 0; row < boardSize; row++)
            {
                for(int col = 0; col < boardSize; col++)
                {
                    grid[row, col] = new GameCell(-1,-1,false,false,0);
                }
            }
        }

        //Properties
        private int BoardSize { get; set; }
        private int GameDifficulty { get; set; }
        public GameCell[,] grid;


        /*
         * The SetupLiveMembers method is responsible for setting the live bombs on the gameboard. This is done by random
         * numbers for the rows and columns in the two-dimentional array. To prevent from not placeing the proper number 
         * of mines on the field, an if statment surrounded by a do/while will check the IsLive property of each randomly 
         * selected GameCell in the array. If it is false, the mine will be planted and the loop ends. 
         */
        public void SetupLiveMembers(int difficulty)
        {
            int numMines = (BoardSize * BoardSize) / difficulty;

            Random row = new Random();
            Random col = new Random();
                
            for(int bombCount = 0; bombCount < numMines; bombCount++)
            {
                bool checker = false;
                do
                {
                    int plantRow = row.Next(0, BoardSize);
                    int plantCol = col.Next(0, BoardSize);

                    if (grid[plantRow, plantCol].IsLive == false)
                    {
                        grid[plantRow, plantCol].IsLive = true;
                        checker = true;
                    }
                } while (checker == false);
            }

        }

        /*
         * The purpose of the CalcLiveMembers method is to set the number of mines that neighbor each cell. This will be used
         * in the displaying of the board.
         */
        public int CalcLiveMembers(int focusRow, int focusCol)
        {
            int liveNeighborCnt = 0;

            //if the cell has a mine on it
            if(grid[focusRow, focusCol].IsLive)
            {
                liveNeighborCnt = 9;
            }

            // case of top right corner
            else if(focusRow == 0 && focusCol == 0)
            {

                if (grid[focusRow, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                
            }

            //case of botom right corner
            else if(focusRow == BoardSize - 1 && focusCol == 0)
            {
                if (grid[focusRow - 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
            }

            //case of bottom left corner
            else if(focusRow == BoardSize - 1 && focusCol == BoardSize - 1)
            {
                if (grid[focusRow, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow  - 1, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }

            }
            
            //case of top left corner
            else if (focusRow == 0 && focusCol == BoardSize - 1)
            {
                if (grid[focusRow, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }

            }

            // case Top Edge
            else if(focusRow == 0 && focusCol != 0)
            {
                if(grid[focusRow, focusCol-1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }
                
            }

            // case left Edge            
            else if (focusRow != 0 && focusCol == 0)
            {
                if (grid[focusRow - 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }

            }
            // case right Edge
            else if (focusRow != 0 && focusRow != BoardSize - 1  && focusCol == BoardSize - 1 )
            {
                if (grid[focusRow - 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol -1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }

            }
            // case Bottom Edge
            else if (focusRow == (BoardSize - 1) && focusCol != (BoardSize - 1))
            {
                if (grid[focusRow, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }

            }
            // case not corner or edge
            else
            {
                if (grid[focusRow, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow - 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol + 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol - 1].IsLive)
                {
                    liveNeighborCnt++;
                }
                if (grid[focusRow + 1, focusCol].IsLive)
                {
                    liveNeighborCnt++;
                }
            }
            grid[focusRow, focusCol].LiveNeighbors = liveNeighborCnt;
            return liveNeighborCnt;
        }

        /*
         * The purpose of FloodFill is to set the visited property to true for all cells that are touching a selected cell 
         * that have the same liveMembers total. This is done recursivly 
         */
        public void FloodFill(int r, int c)
        {

            // sets the current cell to activestate true
            grid[r, c].ActiveState = true;
           
            if (OutOfboundsCheck(r, c) && grid[r,c].LiveNeighbors == 0)
            {
                if(OutOfboundsCheck(r + 1, c) && grid[r + 1, c].ActiveState == false && grid[r + 1, c].LiveNeighbors != 9)
                {
                    FloodFill(r + 1, c);
                    
                }
                    
               
                if (OutOfboundsCheck(r, c + 1) && grid[r, c + 1].ActiveState == false && grid[r, c + 1].LiveNeighbors != 9)
                {
                    FloodFill(r, c + 1);
                }
                    

                if (OutOfboundsCheck(r - 1, c) && grid[r - 1, c].ActiveState == false && grid[r - 1, c].LiveNeighbors != 9)
                {
                    FloodFill(r - 1, c);
                }
                    

                if (OutOfboundsCheck(r, c - 1) && grid[r, c - 1].ActiveState == false && grid[r, c - 1].LiveNeighbors != 9)
                {
                    FloodFill(r, c - 1);
                }
                    
                
                //diagnals
                if (OutOfboundsCheck(r + 1, c + 1) && grid[r + 1, c + 1].ActiveState == false && grid[r + 1, c + 1].LiveNeighbors != 9)
                {
                    FloodFill(r + 1, c + 1);
                }
                    

                if (OutOfboundsCheck(r - 1, c + 1) && grid[r - 1, c + 1].ActiveState == false && grid[r - 1, c + 1].LiveNeighbors != 9)
                {
                    FloodFill(r - 1, c + 1);
                }
                    

                if (OutOfboundsCheck(r - 1, c - 1) && grid[r - 1, c - 1].ActiveState == false && grid[r - 1, c - 1].LiveNeighbors != 9)
                {
                    FloodFill(r - 1, c - 1);
                }
                    

                if (OutOfboundsCheck(r + 1, c - 1) && grid[r + 1, c - 1].ActiveState == false && grid[r + 1, c - 1].LiveNeighbors != 9)
                {
                    FloodFill(r + 1, c - 1);
                }
            }

        }

        // This method checks if the given row and column is in bounds of the game board array
        public bool OutOfboundsCheck(int r, int c)
        {
            if (r >= 0 && r < BoardSize && c >= 0 && c < BoardSize )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      

    }

}
