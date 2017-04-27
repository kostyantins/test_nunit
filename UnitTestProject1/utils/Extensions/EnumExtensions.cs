using System;
using System.Text.RegularExpressions;

namespace TestProject.utils
{
    public static class EnumExtensions
    {
        public static string AsSentense(this Enum currentEnum)
        {
            var splitByCapitalsRegex = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            var splittedString = splitByCapitalsRegex.Replace(currentEnum.ToString(), " ");

            return splittedString.Substring(0, 1) + splittedString.Substring(1).ToLower();
        }
    }
} 