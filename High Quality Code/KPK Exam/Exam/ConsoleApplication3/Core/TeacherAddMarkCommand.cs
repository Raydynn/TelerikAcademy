using System.Collections.Generic;

namespace ConsoleApplication3.Core
{
    internal class TeacherAddMarkCommand : ICommand
    {
        public string Execute(IList<string> teacherStudentParams)
        {
            var teecherid = int.Parse(teacherStudentParams[0]);
            var studentid = int.Parse(teacherStudentParams[1]);

            var student = Engine.Students[teecherid];
            var teacher = Engine.Teachers[studentid];
            teacher.AddMark(student, float.Parse(teacherStudentParams[2]));
            var returnValue = $"Teacher {teacher.firstName} {teacher.lastName} added mark {float.Parse(teacherStudentParams[2])} to student {student.firstName} {student.lastName} in {teacher.subject}.";

            return returnValue;
        }
    }
}
