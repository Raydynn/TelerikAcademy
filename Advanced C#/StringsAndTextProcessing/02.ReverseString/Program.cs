using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class Program
    {

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main()
        {
            string inputStr = Console.ReadLine();
            string reversed = Reverse(inputStr);
            
            Console.WriteLine(reversed);
        }
    }
}
