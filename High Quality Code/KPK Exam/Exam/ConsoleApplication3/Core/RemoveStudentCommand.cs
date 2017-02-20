using System.Collections.Generic;

namespace ConsoleApplication3.Core
{
    internal class RemoveStudentCommand : ICommand
    {
        public string Execute(IList<string> studentParams)
        {
            Engine.Students.Remove(int.Parse(studentParams[0]));
            return $"Student with ID {int.Parse(studentParams[0])} was sucessfully removed.";
        }
    }
}
