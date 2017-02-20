namespace ConsoleApplication3.Common
{
    internal class Constants
    {
        // String Lengths
        public const int MinNameLength = 2;
        public const int MaxNameLength = 31;

        // Numbers validation
        public const int MinGrade = 1;
        public const int MaxGrade = 12;
        public const float MinMarkValue = 2;
        public const float MaxMarkValue = 6;

        // Strings for validation
        public const string StringMustBeBetweenMinAndMax = "{0} must be between {1} and {2} characters long!";
        public const string NumberMustBeBetweenMinAndMax = "{0} must be between {1} and {2}!";

        // Regex pattern for name validation
        public const string NamePattern = "^[A-Za-z]";

        // Strings for name
        public const string InvalidSymbols = "{0} contains invalid symbols!";
    }
}
