using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Core
{
    internal class RemoveTeacherCommand : ICommand
    {
        public string Execute(IList<string> teacherParams)
        {
            Engine.Teachers.Remove(int.Parse(teacherParams[0]));
            return $"Teacher with ID {int.Parse(teacherParams[0])} was sucessfully removed.";
        }
    }
}
