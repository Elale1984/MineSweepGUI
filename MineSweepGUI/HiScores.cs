using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweepGUI
{
    public partial class HiScores : Form
    {
        public HiScores()
        {
            InitializeComponent();
        }

        private void HiScores_Load(object sender, EventArgs e)
        {
            

            PlayerStats ps = new PlayerStats();
            List<PlayerStats> playerStatsList = ps.DBToList();

            AssignValues(playerStatsList);

           
        }

        private void AssignValues(List<PlayerStats> playerStatsList)
        {
            lbl_Init1.Text = playerStatsList[0].playerInitials;
            lbl_Init2.Text = playerStatsList[1].playerInitials;
            lbl_Init3.Text = playerStatsList[2].playerInitials;
            lbl_Init4.Text = playerStatsList[3].playerInitials;
            lbl_Init5.Text = playerStatsList[4].playerInitials;
            lbl_HS1.Text = playerStatsList[0].secondsElapsed.ToString();
            lbl_HS2.Text = playerStatsList[1].secondsElapsed.ToString();
            lbl_HS3.Text = playerStatsList[2].secondsElapsed.ToString();
            lbl_HS4.Text = playerStatsList[3].secondsElapsed.ToString();
            lbl_HS5.Text = playerStatsList[4].secondsElapsed.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
