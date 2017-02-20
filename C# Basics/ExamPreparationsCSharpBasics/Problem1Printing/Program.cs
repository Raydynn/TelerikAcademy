using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Printing
{
    class Program
    {
        static void Main()
        {
            double n = Double.Parse(Console.ReadLine());
            double s = Double.Parse(Console.ReadLine());
            double p = Double.Parse(Console.ReadLine());

            double result = ((n * s) / 500) * p;

            Console.WriteLine("{0:F2}", result);
        }
    }
}
