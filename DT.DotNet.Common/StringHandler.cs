using System;

namespace DT.DotNet.Common
{
    public static class StringHandler // does not maintain state, so use static, cannot be instantiated
    {
        /// <summary>
        /// Add spaces
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source) // this to define an extension method, so it's available on every value of that type. only possible in static class
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result += letter;
                }
            }

            return result.Trim();
        }
    }
}
