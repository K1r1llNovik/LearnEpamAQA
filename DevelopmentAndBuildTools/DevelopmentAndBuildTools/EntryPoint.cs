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
        public static int GetMaxCountOfUniqueSequenceOfLetters(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int count = 1;
            int maxCount = 1;

            for(int i = 0; i < str.Length-1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    count++;
                }

                if (str[i] == str[i + 1])
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
