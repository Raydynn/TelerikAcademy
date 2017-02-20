using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OddOrEven
{
    class Program
    {
        static void Main()
        {
            int num = Int32.Parse(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("even {0}", num);
            }
            else
            {
                Console.WriteLine("odd {0}", num);
            }
        }
    }
}
