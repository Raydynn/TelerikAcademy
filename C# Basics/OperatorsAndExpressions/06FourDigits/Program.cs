using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FourDigits
{
    class Program
    {
        static void Main()
        {
            string num = Console.ReadLine();

            int a = (int)Char.GetNumericValue(num[0]);
            int b = (int)Char.GetNumericValue(num[1]);
            int c = (int)Char.GetNumericValue(num[2]);
            int d = (int)Char.GetNumericValue(num[3]);

            int sum = a + b + c + d;

            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
