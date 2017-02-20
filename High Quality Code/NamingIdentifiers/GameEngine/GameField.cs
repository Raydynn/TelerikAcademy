using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.GameEngine
{
    class GameField
    {
        internal static void CreateGameField(char[,] field)
        {
            int row = field.GetLength(0);
            int column = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < column; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }
    }
}
