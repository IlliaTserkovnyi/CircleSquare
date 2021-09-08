using System;
using System.Text.RegularExpressions;

namespace CircleSquare
{
    public static class DigitValidationHelper
    {
        const string PATTERN = @"^(\d*)(((\.|\,)?)|(\/[1-9]+))(\d*)$";

        public static bool IsDigitIn(string item)
        {
            return Regex.IsMatch(item, PATTERN); 
        }

        public static bool IsSlashInside(string item) 
        {
            return item.Contains('/');
        }

    }
}
