using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.GameEngine
{
    class MineField
    {
        internal static char[,] CreateMineField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }
    }
}
