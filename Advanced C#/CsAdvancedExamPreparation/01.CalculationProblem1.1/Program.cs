using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculationProblem1._1
{
    class Program
    {
        static int BaseNToDecimal(string nValue)
        {
            int sum = 0;
            int someNum = 0;
            for (int i = 0; i < nValue.Length; i++)
            {
                someNum = nValue[i] - 'a';
                sum = someNum + sum * 23;
            }

            return sum;
        }

        static string DecimalToMeow(int value)
        {
            string decToMeow = "";
            int currentNumHolder = 0;
            StringBuilder sb = new StringBuilder();
            while (value != 0)
            {
                currentNumHolder = value % 23;
                sb.Insert(0 ,(char)(currentNumHolder + 'a'));
                value /= 23;
            }
            decToMeow = sb.ToString();
            return decToMeow;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += BaseNToDecimal(input[i]);
            }

            Console.WriteLine(DecimalToMeow(sum) + " = " + sum);
        }
    }
}
