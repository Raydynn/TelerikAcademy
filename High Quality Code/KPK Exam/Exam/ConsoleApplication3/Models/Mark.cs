using ConsoleApplication3.Common;

namespace ConsoleApplication3
{
    internal class Mark
    {
        public readonly float markValue;
        public readonly Subjct subject;

        public Mark(Subjct subject, float markValue)
        {
            Validator.MarkValueValidator(markValue);

            this.subject = subject;
            this.markValue = markValue;
        }
    }
}
