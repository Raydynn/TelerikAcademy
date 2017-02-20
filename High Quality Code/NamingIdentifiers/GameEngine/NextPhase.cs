using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Minesweeper.GameEngine;


namespace Minesweeper.GameEngine
{
    class NextPhase
    {
        internal static void NextTurn(char[,] field,
            char[,] bombs, int row, int column)
        {
            char bombsCount = MinesCount.MineCounter(bombs, row, column);
            bombs[row, column] = bombsCount;
            field[row, column] = bombsCount;
        }
    }
}
