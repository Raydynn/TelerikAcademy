using System;

class FibonacciNumbers
{
    static void Main()
    {
        int members = int.Parse(Console.ReadLine());
        int firstPrevious = -1;
        int secondPreviuos = 1;
        int sum = 0;

        for (int i = 0; i < members; i++)
        {
            sum = firstPrevious + secondPreviuos;
            if (i != members - 1)
            {
                Console.Write(sum + ", ");
            }
            else
            {
                Console.WriteLine(sum);
            }

            firstPrevious = secondPreviuos;
            secondPreviuos = sum;
        }
    }
}