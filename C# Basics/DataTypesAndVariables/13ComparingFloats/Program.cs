using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double eps = 0.000001;
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double difference = 0;

            if (numberA > numberB)
            {
                difference = numberA - numberB;
            }
            else
            {
                difference = numberB - numberA;
            }

            if (difference > eps)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
