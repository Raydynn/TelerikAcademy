using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem3SaddyKopper
{
    class Program
    {
        static void Main()
        {
            BigInteger inputNum = Int64.Parse(Console.ReadLine());
            int transformationCount = 0;
            List<int> digits = Num2List(inputNum);

            for (int i = 1; i <= 11; i++)
            {
                BigInteger product = 1;
                while (digits.Count > 0)
                {
                    digits.RemoveAt(digits.Count - 1);
                    if (digits.Count == 0)
                    {
                        break;
                    }
                    BigInteger evenSum = 0;
                    for (int j = 0; j < digits.Count; j += 2)
                    {
                        evenSum += digits[j];
                    }
                    product *= evenSum;
                    if (digits.Count % 2 == 0 && digits.Count > 0)
                    {
                        product *= evenSum;
                        digits.RemoveAt(digits.Count - 1);
                    }
                }
                transformationCount++;
                digits = Num2List(product);
                if (digits.Count == 1 || transformationCount == 10)
                {                    
                    if (transformationCount !=10)
                    {
                        Console.WriteLine(transformationCount);
                    }
                    Console.WriteLine(product);
                    return;
                }
            }
        }

        private static List<int> Num2List(BigInteger inputNum)
        {
            BigInteger holder = inputNum;
            string str = holder.ToString();
            List<int> digits = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                digits.Add(str[i] - '0');
            }
            
            return digits;
        }
    }
}
