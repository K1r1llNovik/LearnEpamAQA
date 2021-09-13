using System;

namespace DevelopmentAndBuildTools
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                CountingCharacters counter = new CountingCharacters();
                Console.WriteLine(counter.GetMaxOfTheSameDigit(args[0]));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
