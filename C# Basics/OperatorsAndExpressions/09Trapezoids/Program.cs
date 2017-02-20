using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Trapezoids
{
    class Program
    {
        static void Main()
        {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double h = Double.Parse(Console.ReadLine());

            double area = h * ((a + b) / 2);

            Console.WriteLine("{0:0.0000000}", area);
        }
    }
}
