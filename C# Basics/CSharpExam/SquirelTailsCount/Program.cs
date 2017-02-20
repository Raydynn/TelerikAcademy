using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquirelTailsCount
{
    class Program
    {
        static void Main()
        {
            double treesCount = Double.Parse(Console.ReadLine());
            double branchesCount = Double.Parse(Console.ReadLine());
            double squrelsOnBranch = Double.Parse(Console.ReadLine());
            double squirrelTailsCount = Double.Parse(Console.ReadLine());

            double totalTails = (((treesCount * branchesCount) * squrelsOnBranch) * squirrelTailsCount);

            if (totalTails % 2 == 0)
            {
                totalTails *= 376439;
                Console.WriteLine("{0:F3}", totalTails);
            }
            else
            {
                totalTails /= 7;
                Console.WriteLine("{0:F3}", totalTails);
            }
        }
    }
}
