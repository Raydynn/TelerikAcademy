using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5AltSolution
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            number /= 100;
            number %= 10;

            bool isSeven = (number == 7);
            if (isSeven)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + number);
            }
        }
    }
}
