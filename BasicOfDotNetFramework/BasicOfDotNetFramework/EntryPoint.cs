using System;

namespace BasicOfDotNetFramework
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                NumberConverter number = new NumberConverter();
                Console.WriteLine(number.GetConvertNumber(20, 0));
            }

            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
