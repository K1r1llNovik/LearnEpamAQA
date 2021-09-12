using System;
using DesignPatterns.Interfaces;
using DesignPatterns.Commands;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            CommandReader commandReader = new CommandReader();
            Car car1 = new Car("bmw", "x6", 3, 3000);
            Console.WriteLine("print -commands- to see a list of commands");

            while (true)
            {
                ICommand command = commandReader.GetCommand(Console.ReadLine().Split(' '));
                invoker.ExecuteCommand(command);
            }

        }
    }
}
