using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10EmployeeData
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0 || age > 100)
            {
                throw new IndexOutOfRangeException("Age must be between 0 and 100.");
            }
            char gender = Convert.ToChar(Console.ReadLine());
            if (gender != 'f' && gender != 'm')
            {
                throw new Exception("Gender value must be either \"f\" or \"m\".");
            }
            long id = Convert.ToInt64(Console.ReadLine());
            long uniqueEmployeeNumber = Convert.ToInt64(Console.ReadLine());
        }
    }
}
