using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.GameEngine
{
    class MinesCount
    {
        internal static char MineCounter(char[,] field, int row, int column)
        {
            int counter = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, column] == '*')
                {
                    counter++;
                }
            }
            if (row + 1 < rows)
            {
                if (field[row + 1, column] == '*')
                {
                    counter++;
                }
            }
            if (column - 1 >= 0)
            {
                if (field[row, column - 1] == '*')
                {
                    counter++;
                }
            }
            if (column + 1 < columns)
            {
                if (field[row, column + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (field[row - 1, column - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (field[row - 1, column + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (field[row + 1, column - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (field[row + 1, column + 1] == '*')
                {
                    counter++;
                }
            }
            return char.Parse(counter.ToString());
        }
    }
}
