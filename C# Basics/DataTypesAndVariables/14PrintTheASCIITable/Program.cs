using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14PrintTheASCIITable
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.ASCII;
            char ascii = '0';

            for (int i = 33; i <= 126; i++)
            {
                ascii = Convert.ToChar(i);
                Console.Write(ascii);
                if (i == 126)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
