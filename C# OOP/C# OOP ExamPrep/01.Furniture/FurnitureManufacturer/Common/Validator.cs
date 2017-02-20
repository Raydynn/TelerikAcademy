using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furnitures.Common
{
    class Validator
    {
        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }
        public static void CheckIfStringIsNullOrEmpty(string str, string message = null)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new NullReferenceException(message);
            }
        }
        public static void CheckIfStringIsNullOrEmptyOrLessThan(string str, int minLenght, string message = null)
        {
            if (String.IsNullOrEmpty(str) || str.Length < minLenght)
            {
                throw new NullReferenceException(message);
            }
        }
        public static void CheckIfDecLessThanZero(decimal number, string message = null)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}
