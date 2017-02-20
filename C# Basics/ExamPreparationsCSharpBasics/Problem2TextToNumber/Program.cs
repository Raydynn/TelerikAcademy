using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2TextToNumber
{
    public static class Extension
    {
        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
    }

    class Program
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            inputText = inputText.ToLower();

            int result = 0;

            for (int i = 0; i < inputText.Length; i++)
            {
                char currentSymbol = inputText[i];
                if (inputText[i] == '@')
                {
                    Console.WriteLine(result);
                    break;
                }
                else if (Char.IsNumber(currentSymbol))
                {
                    result = result * (currentSymbol - 48);
                }
                else if (char.IsLetter(currentSymbol))
                {
                    result = result + (currentSymbol - 97);
                }
                else
                {
                    result = result % m;
                }
            }

        }
    }
}
