using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculationProblem
{
    class Program
    {
        static int IntPow(int x, int pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }

        static void Main()
        {
            string input = Console.ReadLine();
            string[] list = input.Split(' ');
            string currentUsed = string.Empty;
            List<int> currentWord = new List<int>();
            int currentWordSum = 0;
            int totalSum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                currentUsed = list[i];
                for (int j = 0; j < currentUsed.Length; j++)
                {
                    currentWord.Add(currentUsed[j] - 'a');

                    if (j == (currentUsed.Length - 1))
                    {
                        for (int k = 0; k < currentWord.Count; k++)
                        {
                            currentWordSum += currentWord[k] * IntPow(23,((currentWord.Count - 1) - k));
                        }
                    }
                }
                totalSum += currentWordSum;
                currentWordSum = 0;
            }

            Console.WriteLine(totalSum);
        }
    }
}
