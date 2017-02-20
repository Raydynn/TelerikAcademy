using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            int temp = 0;
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine("After the switch: a = {0}, b = {1}", a, b);
        }
    }
}
