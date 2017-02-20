using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] sequence = new int[n];

            for (int i = 0; i < n; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sequence);

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.WriteLine(sequence[i]);
            }
        }
    }
}
