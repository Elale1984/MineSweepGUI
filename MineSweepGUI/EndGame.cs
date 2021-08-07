using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweepGUI
{
    public partial class EndGame : Form
    {
        
        public string init;

        public EndGame(int endMin, int endSec, bool winner, int gameLevel)
        {
            InitializeComponent();
           
            EndGameDisplay(endMin, endSec, winner, gameLevel); // method call for setting the end game display
            
        }


        /*
         *  This method launches the endgame form which displays appropriate
         *  color scheme and message depending on if the player wins or looses
         *  also, if the player wins, the EnterPlayerName form lauches as a
         *  dialogue to allow the player to enter their initials to be saved
         *  in a text doc
         */

        private void EndGameDisplay(int endMin, int endSec, bool winner, int gameLevel)
        {
            if (winner)
            {
                int seconds = (endMin * 60) + endSec;

                EnterPlayerName epn = new EnterPlayerName(seconds, gameLevel);
                epn.ShowDialog();

                

                lbl_GameOver.ForeColor = Color.Lime;
                
                lbl_EndMessage.ForeColor = Color.Lime;
                lbl_EndMessage.Text = "You Won!!";

                lbl_GameTimer.ForeColor = Color.Lime;

                lbl_Time.ForeColor = Color.Lime;
                lbl_Time.Text = endMin + ":" + endSec;

                btn_PlayAgain.ForeColor = Color.Lime;
                btn_Quit.ForeColor = Color.Lime;
            }
            else
                lbl_Time.Text = endMin + ":" + endSec;


        }

        //Button click event to quit the game. Exits the application
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Button Click event to play again. Closes all forms and launches form 1 
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            Form1 newGame = new Form1();
            newGame.Show();
            CloseAllForms();
        }


        //this method closes all previous forms
        private static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
            {
                
                if (f.Name != "Form1")
                    f.Dispose();
            }
        }

    }
}
