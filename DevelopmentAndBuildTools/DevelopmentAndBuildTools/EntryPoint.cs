using System;

namespace DevelopmentAndBuildTools
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(GetMaxCountOfUniqueSequenceOfLetters(args[0]));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Method which calculating max amount of unique symbols in string
        /// </summary>
        /// <param name="str">Calculated string</param>
        /// <returns>Max count of unique symbols</returns>
        static int GetMaxCountOfUniqueSequenceOfLetters(string sequenceOfCounting)
        {
            if (string.IsNullOrEmpty(sequenceOfCounting))
            {
                return 0;
            }

            int count = 1;
            int maxCount = 1;

            for(int i = 0; i < sequenceOfCounting.Length-1; i++)
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

            if (count > maxCount)
            {
                maxCount = count;
            }

            return maxCount;
        }
    }
}
