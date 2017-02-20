using ConsoleApplication3;
using NUnit.Framework;

namespace ConsoleApplication3Tests
{
    [TestFixture]
    public class ModelsTests
    {
        [Test]
        public void Student_WhenValidCorrespondingValuesArePassed_ShouldReturnNewStudent()
        {
            var student = new Student("Pesho", "Petrov", Grade.Tenth);
            
            Assert.IsInstanceOf<Student>(student);
        }

        [Test]
        public void Teacher_WhenValidCorrespondingValuesArePassed_ShouldReturnNewTeacher()
        {
            var teacher = new Teachers("Gosho", "Vesheff", Subjct.Bulgarian);

            Assert.IsInstanceOf<Teachers>(teacher);
        }
    }
}
