using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public static Person CreatePerson(int age)
        {
            var person = new Person();
            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "Man";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Woman";
                person.Gender = Gender.Female;
            }

            return person;
        }
    }
}
