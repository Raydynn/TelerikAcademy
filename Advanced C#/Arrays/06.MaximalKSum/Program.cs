using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaximalKSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbersArr = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                numbersArr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbersArr);
            Array.Reverse(numbersArr);

            for (int i = 0; i < k; i++)
            {
                sum += numbersArr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
