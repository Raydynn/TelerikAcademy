using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BankAccountData
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your middle name:");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Your current ballance is:");
            decimal balance = 69000000.69M;
            Console.WriteLine(balance);
            Console.WriteLine("Please enter your IBAN \"Note: IBAN should be exactly 34 characters\"");
            string iban = Console.ReadLine();
            if (iban.Length > 34 || iban.Length < 34)
            {
                throw new IndexOutOfRangeException("IBAN should be exactly 34 characters");
            }
            Console.WriteLine("Please enter your first credit card number \"Note: All credit card number should be exactly 12 integers long and without any spaces.\":");
            string firstCard = Console.ReadLine();
            if (Extension.IsNumeric(firstCard) == false || firstCard.Length != 12)
            {
                throw new IndexOutOfRangeException("Ivalid credit card number");
            }
            Console.WriteLine("Please enter your second credit card number:");
            string secondCard = Console.ReadLine();
            if (Extension.IsNumeric(secondCard) == false || secondCard.Length != 12)
            {
                throw new IndexOutOfRangeException("Ivalid credit card number");
            }
            Console.WriteLine("Please enter your third credit card number:");
            string thirdCard = Console.ReadLine();
            if (Extension.IsNumeric(thirdCard) == false || thirdCard.Length != 12)
            {
                throw new IndexOutOfRangeException("Ivalid credit card number");
            }
            Console.WriteLine("xD");
        }
    }
}

public static class Extension
{
    public static bool IsNumeric(this string s)
    {
        float output;
        return float.TryParse(s, out output);
    }
}