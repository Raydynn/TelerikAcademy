using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    internal class CreateStudentCommand : ICommand
    {
        private static int id = 0;

        public string Execute(IList<string> parameters)
        {
            Engine.Students.Add(id, new Student(parameters[0], parameters[1], (Grade)int.Parse(parameters[2])));
            var returnValue = $"A new student with name {parameters[0]} {parameters[1]}, grade {(Grade)int.Parse(parameters[2])} and ID {id++} was created.";
            return returnValue;
        }
    }
}
