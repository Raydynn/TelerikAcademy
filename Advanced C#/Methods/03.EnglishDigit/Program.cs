using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishDigit
{
    class Program
    {
        public static string DigitAsWord(int inputNum)
        {
            int lastDigit = inputNum % 10;
            string[] numbersAsWord = new string[10];
            numbersAsWord[0] = "zero";
            numbersAsWord[1] = "one";
            numbersAsWord[2] = "two";
            numbersAsWord[3] = "three";
            numbersAsWord[4] = "four";
            numbersAsWord[5] = "five";
            numbersAsWord[6] = "six";
            numbersAsWord[7] = "seven";
            numbersAsWord[8] = "eight";
            numbersAsWord[9] = "nine";

            string output = numbersAsWord[lastDigit];

            return numbersAsWord[lastDigit];
        }
        static void Main()
        {
            int number = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine(DigitAsWord(number));
        }
    }
}
