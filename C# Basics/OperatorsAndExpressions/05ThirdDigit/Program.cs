using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            string reversedNum = Reverse(num.ToString());

            if (reversedNum.Length >= 2)
            {
                if (reversedNum[2] == '7')
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false {0}", reversedNum[2]);
                }
            }
            else
            {
                Console.WriteLine("false 0");
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}
