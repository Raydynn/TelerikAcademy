using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class Program
    {
        static void Main()
        {
            int numbersCount = Int32.Parse(Console.ReadLine());
            int[] firstArray = new int[numbersCount];
            int[] secondArray = new int[numbersCount];


            for (int i = 0; i < numbersCount; i++)
            {
                firstArray[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbersCount; i++)
            {
                secondArray[i] = Int32.Parse(Console.ReadLine());
            }

            if (firstArray.SequenceEqual(secondArray))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
