using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FirstLargerThanNeighbours
{
    class Program
    {
        public static int FirstLargerThanNeighbours(int[] numbers)
        {
            for (int i = 1; i < (numbers.Length - 1); i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main()
        {
            int arraySize = Int32.Parse(Console.ReadLine());
            string numbersLine = Console.ReadLine();
                        
            string[] inputNumbers = numbersLine.Split(' ');
            int[] convertedNumbers = Array.ConvertAll<string, int>(inputNumbers, int.Parse);

            Console.WriteLine(FirstLargerThanNeighbours(convertedNumbers));
        }
    }
}
