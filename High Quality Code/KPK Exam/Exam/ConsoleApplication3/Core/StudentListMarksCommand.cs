using System.Collections.Generic;

namespace ConsoleApplication3.Core
{
    internal class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            return Engine.Students[int.Parse(parameters[0])].ListMarks();
        }
    }
}
