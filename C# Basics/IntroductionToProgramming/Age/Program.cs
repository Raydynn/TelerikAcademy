using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in the format MM/DD/YYYY");
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(CurrentAge(DateTime.Now, dateOfBirth));
            Console.WriteLine(CurrentAge(DateTime.Now.AddYears(10), dateOfBirth));

        }

        static int CurrentAge(DateTime currentDate, DateTime dateOfBirth)
        {
            int years = currentDate.Year - dateOfBirth.Year;
            DateTime currentBirthDay = new DateTime(DateTime.Now.Year, dateOfBirth.Month, dateOfBirth.Day);

            if (currentBirthDay > DateTime.Now)
            {
                years--;
            }

            return years;
        }
    }
}
