using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Minesweeper;
using Minesweeper.GameEngine;

namespace Minesweeper.GameEngine
{
    class Engine
    {
        internal static void StartGame()
        {
            string command = string.Empty;
            char[,] gameField = MineField.CreateMineField();
            char[,] bombs = Mine.CreateMine();
            int counter = 0;
            bool isExploding = false;
            List<HighScore> champions = new List<HighScore>(6);
            int row = 0;
            int column = 0;
            bool isGameStarting = true;
            const int max = 35;
            bool isGameOver = false;

            do
            {
                if (isGameStarting)
                {
                    Console.WriteLine("Let's play “Mine Sweeper”. Try your luck and flag all mines." +
                    " Command 'top' shows all highscores, 'restart' starts new game, 'exit' exits the game!");
                    GameField.CreateGameField(gameField);
                    isGameStarting = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        HallOfFame.HighScores(champions);
                        break;
                    case "restart":
                        gameField = MineField.CreateMineField();
                        bombs = Mine.CreateMine();
                        GameField.CreateGameField(gameField);
                        isExploding = false;
                        isGameStarting = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye! Bye!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                NextPhase.NextTurn(gameField, bombs, row, column);
                                counter++;
                            }
                            if (max == counter)
                            {
                                isGameOver = true;
                            }
                            else
                            {
                                GameField.CreateGameField(gameField);
                            }
                        }
                        else
                        {
                            isExploding = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (isExploding)
                {
                    GameField.CreateGameField(bombs);
                    Console.Write("\nDead! Your score is: {0} points. " +
                        "Enter name: ", counter);
                    string nickname = Console.ReadLine();
                    HighScore newHighScore = new HighScore(nickname, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(newHighScore);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Score < newHighScore.Score)
                            {
                                champions.Insert(i, newHighScore);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((HighScore championOne, HighScore championTwo) => championTwo.Name.CompareTo(championOne.Name));
                    champions.Sort((HighScore championOne, HighScore championTwo) => championTwo.Score.CompareTo(championOne.Score));
                    HallOfFame.HighScores(champions);

                    gameField = MineField.CreateMineField();
                    bombs = Mine.CreateMine();
                    counter = 0;
                    isExploding = false;
                    isGameStarting = true;
                }
                if (isGameOver)
                {
                    Console.WriteLine("\nCongratulations! You discovered all 35 fields.");
                    GameField.CreateGameField(bombs);
                    Console.WriteLine("Enter your name Champion: ");
                    string cnampionName = Console.ReadLine();
                    HighScore championHighScore = new HighScore(cnampionName, counter);
                    champions.Add(championHighScore);
                    HallOfFame.HighScores(champions);
                    gameField = MineField.CreateMineField();
                    bombs = Mine.CreateMine();
                    counter = 0;
                    isGameOver = false;
                    isGameStarting = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }
    }
}
