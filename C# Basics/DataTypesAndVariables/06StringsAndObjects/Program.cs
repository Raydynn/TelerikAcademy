using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringsAndObjects
{
    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";

            object helloWorld = hello + " " + world;

            Console.WriteLine(helloWorld);

            string helloWorldStr = helloWorld.ToString();

            Console.WriteLine(helloWorld);
        }
    }
}
