using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class HighScore
    {
        string name;
        int score;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public HighScore() { }

        public HighScore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
