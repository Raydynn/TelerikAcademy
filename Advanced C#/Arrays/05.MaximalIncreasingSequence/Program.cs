using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalIncreasingSequence
{
    class Program
    {
        static void Main()
        {
            int numbersCount = Int32.Parse(Console.ReadLine());
            int[] numbersArr = new int[numbersCount];

            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = Int32.Parse(Console.ReadLine());
            }

            int sequenceCounter = 1;
            int maxSequence = 0;

            for (int i = 1; i < numbersArr.Length; i++)
            {
                if (numbersArr[i - 1] < numbersArr[i])
                {
                    sequenceCounter++;
                }
                else
                {
                    if (maxSequence < sequenceCounter)
                    {
                        maxSequence = sequenceCounter;
                    }
                    sequenceCounter = 1;
                }
            }
            if (maxSequence == 0)
            {
                maxSequence = sequenceCounter;
            }
            Console.WriteLine(maxSequence);
        }
    }
}
