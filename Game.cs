// uploaded on 11-07-17 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib2
{
    public class Game
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Team1score { get; set; }
        public int Team2score { get; set; }

        public Game() { } // default constructor

        public Game(string Team1, string Team2, int Team1score, int Team2score)
        {
            this.Team1 = Team1;
            this.Team2 = Team2;
            this.Team1score = Team1score;
            this.Team2score = Team2score;
        }

        public override string ToString()
        {
            return Team1 + " (" + Team1score + ") " + " - " + Team2 + " (" + Team2score + ")";
        }
    }
}
