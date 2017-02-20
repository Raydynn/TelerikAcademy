using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IncreasingAbsoluteDifferences
{
    class Program
    {

        static bool IsIncreasingAbsoluteDifference(string[] sequence)
        { 
            List<int> absDiff = new List<int>();
        int prevDiff = int.MinValue;
            int currentDiff = -1;

            for (int j = 1; j < sequence.Length; j++)
            {                 
                currentDiff = Math.Abs(int.Parse(sequence[j]) - int.Parse(sequence[j - 1]));
                if (((currentDiff - prevDiff) == 0 && currentDiff >= prevDiff) || ((currentDiff - prevDiff) == 1 && currentDiff >= prevDiff) || j == 1)
                {
                    absDiff.Add(Math.Abs(currentDiff));                    
                }
                prevDiff = currentDiff;
            }
            if (absDiff.Count == sequence.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            int numbOfSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbOfSequences; i++)
            {
                Console.WriteLine(IsIncreasingAbsoluteDifference(Console.ReadLine().Split(' ')));
            }
        }
    }
}
