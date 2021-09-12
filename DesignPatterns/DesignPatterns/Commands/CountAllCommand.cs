using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Commands
{
    public class CountAllCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine(CarGarage.GetCarGarage().GetCountAll());
        }
    }
}
