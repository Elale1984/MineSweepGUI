using System;
using System.Collections.Generic;
using System.Text;

namespace MineSweepGUI
{
    class PlayerStats : IComparable<PlayerStats>
    {
        

        public int difficultyLevel { get; set; }
        public int secondsElapsed { get; set; }
        public  string playerInitials { get; set; }

        public PlayerStats(int difficultyLevel, int secondsElapsed, string playerInitials)
        {
            this.difficultyLevel = difficultyLevel;
            this.secondsElapsed = secondsElapsed;
            this.playerInitials = playerInitials;
        }

        int IComparable<PlayerStats>.CompareTo(PlayerStats other)
        {
            throw new NotImplementedException();
        }
    }
}
