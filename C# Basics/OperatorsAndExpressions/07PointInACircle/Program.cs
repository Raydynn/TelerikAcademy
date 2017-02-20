using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double diameter = (x * x) + (y * y);
            bool inside = diameter <= 4;

            if (inside == true)
            {
                Console.Write("yes ");
            }

            else
            {
                Console.Write("no ");
            }

            Console.Write("{0:0.00}", Math.Sqrt(diameter));
        }
    }
}