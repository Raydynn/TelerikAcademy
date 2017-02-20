using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08PrimeCheck
{
    class Program
    {
        static void Main()
        {
            int num = Int32.Parse(Console.ReadLine());            
            bool isPrime = true;

            if (num < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime == true)
            {
                Console.WriteLine("true");
            }
            else
	        {
                Console.WriteLine("false");
            }
        }
    }
}
