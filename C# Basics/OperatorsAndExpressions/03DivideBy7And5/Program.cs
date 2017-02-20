using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DivideBy7And5
{
    class Program
    {
        static void Main()
        {
            int num = Int32.Parse(Console.ReadLine());

            if (num%5 == 0 && num%7 == 0)
            {
                Console.WriteLine("true {0}", num);
            }
            else
            {
                Console.WriteLine("false {0}", num);
            }
        }
    }
}
