using System;
using System.Collections.Generic;

namespace ConsoleApplication3.Core
{
    internal class CreateTeacherCommand : ICommand
    {
        private static int id = 0;

        public string Execute(IList<string> parameters)
        {
            Engine.Teachers.Add(id, new Teachers(parameters[0], parameters[1], (Subjct)Enum.Parse(typeof(Subjct), parameters[2])));
            var returnValue = $"A new teacher with name {parameters[0]} {parameters[1]}, subject {(Subjct)Enum.Parse(typeof(Subjct), parameters[2])} and ID {id++} was created.";
            return returnValue;
        }
    }
}
