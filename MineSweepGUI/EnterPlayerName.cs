using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweepGUI
{
    public partial class EnterPlayerName : Form
    {
        public static string initials;
        public static int totalSeconds;
        public static int gameDifficulty;
     
        public EnterPlayerName(int seconds, int gameLevel)
        {
            InitializeComponent();
            tb_Initials.Focus();

            totalSeconds = seconds;
            gameDifficulty = gameLevel;

            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            initials = tb_Initials.Text;
            
            

            PlayerStats ps = new PlayerStats();
            ps.playerInitials = initials;
            ps.secondsElapsed = totalSeconds;
            ps.difficultyLevel = gameDifficulty;
            ps.WriteToDB(ps);

            this.Close();
        }

       
    }
}
