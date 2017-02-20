using System.Linq;
using System.Collections.Generic;
using ConsoleApplication3.Common;

namespace ConsoleApplication3
{
    internal class Student
    {
        internal string firstName;
        internal string lastName;
        private Grade studentGrades;
        public readonly List<Mark> markList;

        public Student(string firstName, string lastName, Grade studentGrades)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentGrades = studentGrades;
            this.markList = new List<Mark>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validator.NameLengthValidator(value);
                Validator.ValidateNameSymbols(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Validator.NameLengthValidator(value);
                Validator.ValidateNameSymbols(value);
                this.lastName = value;
            }
        }

        public Grade StudentGrades { get; set; }

        public string ListMarks()
        {
            var listMarks = markList.Select(mark => $"{mark.subject} => {mark.markValue}").ToList();
            var result = string.Join("\n", listMarks);
            return result;
        }
    }
}
