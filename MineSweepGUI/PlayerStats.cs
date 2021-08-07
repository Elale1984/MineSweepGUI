using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MineSweepGUI
{
    class PlayerStats : IComparable<PlayerStats>
    {
        

        public int difficultyLevel { get; set; }
        public int secondsElapsed { get; set; }
        public  string playerInitials { get; set; }

        public static List<PlayerStats> HiScoreList = new List<PlayerStats>();
        

        

        public int CompareTo(PlayerStats other)
        {
            
            if (this.secondsElapsed > other.secondsElapsed)
                return other.secondsElapsed;
            else
                return this.secondsElapsed;

        }

        public List<PlayerStats> DBToList()
        {

            string path = @"C:\Docs\HiScoresDB.txt";
            List<string> ReadInFileLinesList = File.ReadAllLines(path).ToList();

           
            //reads each line from the PlayerStatsList and returns a functional list of type PlayerStats objects
            foreach (string line in ReadInFileLinesList)
            {
                string[] entries = line.Split(',');

                PlayerStats ps = new PlayerStats();

                ps.playerInitials = entries[0];
                ps.secondsElapsed = int.Parse(entries[1]);
                ps.difficultyLevel = int.Parse(entries[2]);

                HiScoreList.Add(ps);


            }



            List<PlayerStats> topFive = HiScoreList.OrderByDescending(x => x.difficultyLevel).Take(5).OrderBy(x => x.CompareTo(x)).ToList();
                
           

            return topFive;
        }
        public void WriteToDB(PlayerStats p)
        {
            string path = @"C:\Docs\HiScoresDB.txt";
            File.AppendAllText(path, p.playerInitials + ", " + p.secondsElapsed.ToString() + ", " + p.difficultyLevel.ToString() + Environment.NewLine);

        }
    }
}
