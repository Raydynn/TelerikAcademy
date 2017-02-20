using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class Program
    {
        static string Sorter(int inputNum, string inputStr)
        {
            string[] inputNumbers = inputStr.Split(' ');
            Array.Sort(inputNumbers);
            string sortedNumbers = string.Join(" ", inputNumbers);

            return sortedNumbers;
        }
        static void Main()
        {
            int arrSize = Int32.Parse(Console.ReadLine());
            string arrNums = Console.ReadLine();

            Console.WriteLine(Sorter(arrSize, arrNums));

        }
    }
}
