using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];

            for (int i = 0; i < n; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }

            int currentMostFrequent = 1;
            int mostFrequent = 1;
            int number = 0;

            Array.Sort(sequence);

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentMostFrequent++;
                    if (currentMostFrequent > mostFrequent)
                    {
                        mostFrequent = currentMostFrequent;
                        number = sequence[i];
                    }
                }
                else
                {
                    currentMostFrequent = 1;
                }
            }

            Console.WriteLine("{0} ({1} times)", number, mostFrequent);
        }
    }

}


