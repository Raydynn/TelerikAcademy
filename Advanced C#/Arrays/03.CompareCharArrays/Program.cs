using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();

            firstStr.ToLower();
            secondStr.ToLower();

            char[] firstArr = firstStr.ToCharArray();
            char[] secondArr = secondStr.ToCharArray();

            int firstArrSum = 0;
            int secondArrSum = 0;
            if (firstArr.Length == secondArr.Length)
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] != ' ')
                    {
                        firstArrSum += (firstArr[i] - 'a');
                    }
                }
                for (int i = 0; i < secondArr.Length; i++)
                {
                    if (secondArr[i] != ' ')
                    {
                        secondArrSum += (secondArr[i] - 'a');
                    }
                }
                if (firstArrSum > secondArrSum)
                {
                    Console.WriteLine(">");
                }
                else if (firstArrSum < secondArrSum)
                {
                    Console.WriteLine("<");
                }
                else
                {
                    Console.WriteLine("=");
                }
            }
            else if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine("<");
            }
        }
    }
}
