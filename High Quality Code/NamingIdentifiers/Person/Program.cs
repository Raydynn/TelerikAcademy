using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main()
        {
            {
                var firstPerson = Person.CreatePerson(20);
                var secondPerson = Person.CreatePerson(21);

                Console.WriteLine(firstPerson.Name);
                Console.WriteLine(secondPerson.Name);
            }
        }
    }
}
