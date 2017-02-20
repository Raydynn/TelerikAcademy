using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08IsoscelesTriangle
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string symbol = "©";
            string space = " ";
            Console.WriteLine(space + space + space + symbol);
            Console.WriteLine(space + space + symbol + space + symbol);
            Console.WriteLine(space + symbol + space + space + space + symbol);
            Console.WriteLine(symbol + space + symbol + space + symbol + space + symbol);
        }
    }
}
