using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class HallOfFame
    {
        internal static void HighScores(List<HighScore> score)
        {
            Console.WriteLine("\nScore:");
            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cases",
                        i + 1, score[i].Name, score[i].Score);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No high scores!\n");
            }
        }
    }
}
