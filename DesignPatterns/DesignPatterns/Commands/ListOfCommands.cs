using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Commands
{
    public class ListOfCommands : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("add - example: -add- -brand- -model- -number of cars- -price of cars-");
            Console.WriteLine("count types - example: -count tyeps-");
            Console.WriteLine("count all - example: -count all-");
            Console.WriteLine("average price - example: -average price-");
            Console.WriteLine("average price type - example: -average price- -brand-");
            Console.WriteLine("exit - example: -exit-");
            Console.WriteLine("commands - example: -commands-");
        }
    }
}
