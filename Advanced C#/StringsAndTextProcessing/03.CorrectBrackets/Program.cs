using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrackets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int openingBrackets = 0;
            int closingBrackets = 0;
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(')'))
                {
                    closingBrackets++;
                }
                else if (input[i].Equals('('))
                {
                    openingBrackets++;
                }
                if (openingBrackets < closingBrackets)
                {
                    result = "Incorrect";
                    break;
                }             
            }
            if (result == "")
            {
                if (openingBrackets != closingBrackets)
                {
                    result = "Incorrect";
                }
                else
                {
                    result = "Correct";
                }
            }
            Console.WriteLine(result);
        }
    }
}
