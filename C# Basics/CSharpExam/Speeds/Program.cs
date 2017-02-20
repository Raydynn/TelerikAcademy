using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeds
{
    class Program
    {
        static void Main()
        {
            int numberOfCars = Int32.Parse(Console.ReadLine());
            int currentCarSpeed = 0;
            List<int> speeds = new List<int>();
            int lastCarSpeed = 0;
            int currentSumOfSpeeds = 0;
            int biggestSumOfSpeeds = 0;
            int lastCurrentSpeedAdded = 0;
            int lastBiggestSpeedAdded = 0;
            int finalSpeedSum = 0;
            int lastSpeedAdded = 0;
            List<int> biggestCarLine = new List<int>();
            List<int> currentCarLine = new List<int>();

            for (int i = 0; i < numberOfCars; i++)
            {
                currentCarSpeed = Int32.Parse(Console.ReadLine());
                speeds.Add(currentCarSpeed);
            }

            for (int i = 0; i < speeds.Count; i++)
            {
                if (i != 0)
                {
                    lastCarSpeed = speeds[i - 1];
                }
                if (speeds[i] >= lastCarSpeed)
                {
                    currentCarLine.Add(speeds[i]);
                }
                if (speeds[i] < lastCarSpeed || speeds.Count == (i + 1))
                {
                    if (currentCarLine.Count > biggestCarLine.Count)
                    {
                        biggestCarLine.Clear();
                        biggestCarLine = new List<int>(currentCarLine);
                        currentCarLine.Clear();
                    }
                    else if (currentCarLine.Count == biggestCarLine.Count)
                    {
                        for (int j = 0; j < currentCarLine.Count; j++)
                        {
                            if (j == 0)
                            {
                                currentSumOfSpeeds += currentCarLine[j];
                                lastCurrentSpeedAdded = currentCarLine[j];
                            }
                            else if (currentCarLine[j] >= currentCarLine[j - 1] && currentCarLine[j] != lastCurrentSpeedAdded)
                            {
                                currentSumOfSpeeds += currentCarLine[j];
                                lastCurrentSpeedAdded = currentCarLine[j];
                            }
                        }
                        for (int j = 0; j < biggestCarLine.Count; j++)
                        {
                            if (j == 0)
                            {
                                biggestSumOfSpeeds += biggestCarLine[j];
                                lastBiggestSpeedAdded = biggestCarLine[j];
                            }
                            else if (biggestCarLine[j] >= biggestCarLine[j - 1] && biggestCarLine[j] != lastBiggestSpeedAdded)
                            {
                                biggestSumOfSpeeds += biggestCarLine[j];
                                lastBiggestSpeedAdded = biggestCarLine[j];
                            }
                        }
                        if (currentSumOfSpeeds > biggestSumOfSpeeds)
                        {
                            biggestCarLine.Clear();
                            biggestCarLine = new List<int> (currentCarLine);
                        }
                        currentCarLine.Clear();
                        currentSumOfSpeeds = 0;
                        biggestSumOfSpeeds = 0;
                    }
                    else
                    {
                        currentCarLine.Clear();
                    }
                }
            }
            for (int i = 0; i < biggestCarLine.Count; i++)
            {
                if (i == 0)
                {
                    finalSpeedSum += biggestCarLine[i];
                    lastSpeedAdded = biggestCarLine[i];
                }
                else if (biggestCarLine[i] >= biggestCarLine[i - 1] && biggestCarLine[i] != lastSpeedAdded)
                {
                    finalSpeedSum += biggestCarLine[i];
                    lastSpeedAdded = biggestCarLine[i];
                }
            }
            Console.WriteLine(finalSpeedSum);
        }
    }
}
