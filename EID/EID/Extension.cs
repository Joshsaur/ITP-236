using System;

namespace EID
{
    /// <summary>
    /// Provides extension methods for primitive data types.
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Converts a string into Proper Case.
        /// Example: "rIVEN sTORM" becomes "Riven Storm".
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>A properly formatted name.</returns>
        public static string ProperName(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            string[] words = value.ToLower().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }

            return string.Join(" ", words);
        }

        /// <summary>
        /// Determines whether an integer is even.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>True if even; otherwise false.</returns>
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}