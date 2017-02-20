using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MoonGravity
{
    class Program
    {
        static void Main()
        {
            float weight = float.Parse(Console.ReadLine());

            float moonWeight = (weight / 100) * 17;

            Console.WriteLine("{0:0.000}", moonWeight);
        }
    }
}
