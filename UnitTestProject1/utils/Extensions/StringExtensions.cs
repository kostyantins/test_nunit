using System.Text.RegularExpressions;

namespace TestProject.utils
{
    public static class StringExtensions
    {
        public static string CamelCaseAsSentence(this string camelCaseString)
        {
            return Regex.Replace(camelCaseString, "(?!^)([A-Z])", " $1");
        }
    }
}