using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class Program
    {
        static string NumberReverser(string inputNum)
        {
            char[] cArray = inputNum.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        static void Main()
        {
            string number = Console.ReadLine();

            Console.WriteLine(NumberReverser(number));
        }
    }
}
