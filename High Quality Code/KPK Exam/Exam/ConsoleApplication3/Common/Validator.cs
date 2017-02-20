using System;
using System.Text.RegularExpressions;

namespace ConsoleApplication3.Common
{
    class Validator
    {
        public static void ValidateLengthOfString(string value, int minLenth, int maxLenth, string message)
        {
            if (value.Length < minLenth || value.Length > maxLenth)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateIntRange(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateFloatRange(float value, float min, float max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void ValidateSymbols(string value, string pattern, string message)
        {
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            if (!regex.IsMatch(value))
            {
                throw new ArgumentException(message);
            }
        }

        public static void NameLengthValidator(string value)
        {
            Validator.ValidateLengthOfString(value, Constants.MinNameLength, Constants.MaxNameLength,
                                string.Format(Constants.StringMustBeBetweenMinAndMax,
                                value.GetType(), Constants.MinNameLength, Constants.MaxNameLength));
        }

        public static void ValidateNameSymbols(string value)
        {
            Validator.ValidateSymbols(value, Constants.NamePattern,
                string.Format(Constants.InvalidSymbols, value.GetType()));
        }

        public static void MarkValueValidator(float markValue)
        {
            Validator.ValidateFloatRange(markValue, Constants.MinMarkValue, Constants.MaxMarkValue,
                string.Format(Constants.NumberMustBeBetweenMinAndMax,
                markValue.GetType(), Constants.MinMarkValue, Constants.MaxMarkValue));
        }
    }
}
