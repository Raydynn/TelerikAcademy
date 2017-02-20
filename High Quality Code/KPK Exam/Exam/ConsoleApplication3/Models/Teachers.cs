using System;
using ConsoleApplication3.Common;

namespace ConsoleApplication3
{
    internal class Teachers
    {
        private const int StudentMarksMax = 20;

        public string firstName;
        public string lastName;
        public Subjct subject;

        public Teachers(string firstName, string lastName, Subjct subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
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

        public Subjct Subject { get; set; }


        public void AddMark(Student student, float markValue)
        {
            if (!(student.markList.Count > StudentMarksMax))
            {
                var mark = new Mark(subject, markValue);
                student.markList.Add(mark);
            }
            else
            {
                throw new ArgumentException(string.Format("A student cannot have more than {0} marks", StudentMarksMax));
            }
        }
    }
}
