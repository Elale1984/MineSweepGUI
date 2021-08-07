using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweepGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int gameDifficulty;
            if (rb_Easy.Checked)
            {
                gameDifficulty = 12;
                this.Hide();
                MineSweeperGame mineSweeperGame = new MineSweeperGame(gameDifficulty);
                mineSweeperGame.Show();
            }
            else if(rb_Medium.Checked)
            {
                gameDifficulty = 10;
                this.Hide();
                MineSweeperGame mineSweeperGame = new MineSweeperGame(gameDifficulty);
                mineSweeperGame.Show();
            }
            else 
            {
                gameDifficulty = 8;
                this.Hide();
                MineSweeperGame mineSweeperGame = new MineSweeperGame(gameDifficulty);
                mineSweeperGame.Show();
            }
           
        }
    }
}
