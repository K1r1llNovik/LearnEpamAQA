using System;
using System.Linq;

namespace DevelopmentAndBuildTools
{
    public static class StringExtencion
    {
        /// <summary>
        /// That method checked string on whitespaces or empty
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if symbol in a string is latin, else false</returns>
        public static bool IsEmptyOrWhiteSpace(this string value) =>
            value.All(char.IsWhiteSpace);
    }
}
