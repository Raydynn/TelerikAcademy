using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenDivisors
{
    class Program
    {
        static void Main()
        {
            int firstNumber = Int32.Parse(Console.ReadLine());
            int secondNumber = Int32.Parse(Console.ReadLine());
            int sumOfDivisors = 0;


            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && j % 2 == 0)
                    {
                        sumOfDivisors += j;
                    }
                }

            }

            Console.WriteLine(sumOfDivisors);
        }
    }
}
