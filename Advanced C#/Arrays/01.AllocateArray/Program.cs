using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AllocateArray
{
    class Program
    {
        static void Main()
        {
            int numbersCount = Int32.Parse(Console.ReadLine());
            int[] numbersArr = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                numbersArr[i] = i * 5;
                Console.WriteLine(numbersArr[i]);
            }
        }
    }
}
