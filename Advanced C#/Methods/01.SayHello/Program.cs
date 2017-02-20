using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SayHello
{
    class Program
    {
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            string enteredName = Console.ReadLine();

            SayHello(enteredName);
        }
    }
}
