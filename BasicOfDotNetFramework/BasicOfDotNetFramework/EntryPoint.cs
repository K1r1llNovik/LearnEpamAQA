using System;

namespace BasicOfDotNetFramework
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                throw new ArgumentException("Invalid meaning of arguments");
            }
            else
            {
                try
                {
                    string result = NumberConverter.GetConvertNumber(uint.Parse(args[0]), uint.Parse(args[1]));
                    Console.WriteLine(result);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
