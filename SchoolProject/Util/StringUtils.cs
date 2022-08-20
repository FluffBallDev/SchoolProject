using System.Linq;

namespace SchoolProject.Util
{
    public static class StringUtils
    {
        /// <summary>
        /// Trimming of a string, made neat with the help of Krutonium
        /// </summary>
        /// <param name="stringToTrim">String to trim</param>
        /// <returns>a trimmed string</returns>
        public static string TrimStr(string stringToTrim)
        {
            char[] chars = {'\\', ':', ';', '/', '\'', '\"', '{', '[', '(', ')', ']', '}', '=', '!', '@'};
            string trimStr = chars.Aggregate(stringToTrim, (s, c) => s.Replace(c, '_'));
            return trimStr.Trim().ToLower();
        }
    }
}