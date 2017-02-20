using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLargestNum
{
    class Program
    {
        public static int GetMax(int nubmerA, int NumberB)
        {
            if (nubmerA >= NumberB)
            {
                return nubmerA;
            }
            else
            {
                return NumberB;
            }
        }

        static void Main()
        {
            string numbersLine = Console.ReadLine();

            string[] inputNumbers = numbersLine.Split(' ');
            int[] convertedNumbers = Array.ConvertAll<string, int>(inputNumbers, int.Parse);

            if (convertedNumbers[0] >= convertedNumbers[1] && convertedNumbers[1] >= convertedNumbers[2])
            {
                Console.WriteLine(GetMax(convertedNumbers[0], convertedNumbers[1]));
            }
            else if (convertedNumbers[0] >= convertedNumbers[2] && convertedNumbers[2] >= convertedNumbers[1])
            {
                Console.WriteLine(GetMax(convertedNumbers[0], convertedNumbers[2]));
            }
            else if (convertedNumbers[1] >= convertedNumbers[0] && convertedNumbers[0] >= convertedNumbers[2])
            {
                Console.WriteLine(GetMax(convertedNumbers[1], convertedNumbers[0]));
            }
            else if (convertedNumbers[1] >= convertedNumbers[2] && convertedNumbers[2] >= convertedNumbers[0])
            {
                Console.WriteLine(GetMax(convertedNumbers[1], convertedNumbers[2]));
            }
            else if (convertedNumbers[2] >= convertedNumbers[1] && convertedNumbers[1] >= convertedNumbers[0])
            {
                Console.WriteLine(GetMax(convertedNumbers[2], convertedNumbers[1]));
            }
            else if (convertedNumbers[2] >= convertedNumbers[0] && convertedNumbers[0] >= convertedNumbers[1])
            {
                Console.WriteLine(GetMax(convertedNumbers[2], convertedNumbers[0]));
            }
        }
    }
}
