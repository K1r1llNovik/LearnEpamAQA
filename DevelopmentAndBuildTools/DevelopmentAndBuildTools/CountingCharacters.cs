using System;
using System.Linq;

namespace DevelopmentAndBuildTools
{
    public class CountingCharacters
    {
        /// <summary>
        /// Method which calculating max amount of unique symbols in string
        /// </summary>
        /// <param name="str">Calculated string</param>
        /// <returns>Max count of unique symbols</returns>
        public int GetMaxCountOfUniqueSequenceOfLetters(string sequenceOfCounting)
        {
            if (sequenceOfCounting is null)
            {
                throw new ArgumentNullException(nameof(sequenceOfCounting));
            }

            if (sequenceOfCounting.IsEmptyOrWhiteSpace())
            {
                return 0;
            }

            int count = 1;
            int maxCount = 1;

            for (int i = 0; i < sequenceOfCounting.Length - 1; i++)
            {
                if (sequenceOfCounting[i] != sequenceOfCounting[i + 1])
                {
                    count++;
                }

                if (sequenceOfCounting[i] == sequenceOfCounting[i + 1])
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = 1;
                }
            }

            return count > maxCount ? count : maxCount;
        }

        /// <summary>
        /// Method which calculating max amount of the same latin letters
        /// </summary>
        /// <param name="sequenceOfCounting"></param>
        /// <returns>Max amount of the same latin letters in string</returns>
        public int GetMaxOfTheSameLatinLetters(string sequenceOfCounting)
        {
            if (sequenceOfCounting == null)
            {
                throw new ArgumentNullException(nameof(sequenceOfCounting));
            }

            if (sequenceOfCounting.IsEmptyOrWhiteSpace())
            {
                return 0;
            }

            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < sequenceOfCounting.Length; i++)
            {
                if (IsLatinSymbol(sequenceOfCounting[i]) && count == 0)
                {
                    count = 1;
                }

                if (IsLatinSymbol(sequenceOfCounting[i]) && i < sequenceOfCounting.Length - 1 && sequenceOfCounting[i] == sequenceOfCounting[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }

            return count > maxCount ? count : maxCount;
        }

        /// <summary>
        /// Method which calculating max amount of the same digits in string
        /// </summary>
        /// <param name="sequenceOfCounting"></param>
        /// <returns>Max amount of the same digits in string</returns>
        public int GetMaxOfTheSameDigit(string sequenceOfCounting)
        {
            if (sequenceOfCounting == null)
            {
                throw new ArgumentNullException(nameof(sequenceOfCounting));
            }

            if (sequenceOfCounting.IsEmptyOrWhiteSpace())
            {
                return 0;
            }

            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < sequenceOfCounting.Length; i++)
            {
                if (Char.IsDigit(sequenceOfCounting[i]) && count == 0)
                {
                    count = 1;
                }

                if (Char.IsDigit(sequenceOfCounting[i]) && i < sequenceOfCounting.Length - 1 && sequenceOfCounting[i] == sequenceOfCounting[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }
            return count > maxCount ? count : maxCount;
        }

        /// <summary>
        /// Method which checked symbols in a string for latin
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns>True if symbol is latin, else false</returns>
        private static bool IsLatinSymbol(char symbol)
        {
            return (symbol >= 'A' && symbol <= 'Z') ||
                (symbol >= 'a' && symbol <= 'z');
        }
    }
}
