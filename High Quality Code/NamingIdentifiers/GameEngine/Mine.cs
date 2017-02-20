using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Minesweeper.GameEngine;

namespace Minesweeper.GameEngine
{
    class Mine
    {
        internal static char[,] CreateMine()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameField[i, j] = '-';
                }
            }
            List<int> minesList = new List<int>();
            while (minesList.Count < 15)
            {
                Random random = new Random();
                int mine = random.Next(50);
                if (!minesList.Contains(mine))
                {
                    minesList.Add(mine);
                }
            }

            foreach (int mine in minesList)
            {
                int col = (mine / columns);
                int row = (mine % columns);
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }
                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        internal static void Calculations(char[,] field)
        {
            int row = field.GetLength(0);
            int column = field.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char bombsCount = MinesCount.MineCounter(field, i, j);
                        field[i, j] = bombsCount;
                    }
                }
            }
        }
    }
}
