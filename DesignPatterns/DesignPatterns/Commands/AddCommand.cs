using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Commands
{
    public class AddCommand : ICommand
    {
        private Car _car;

        public AddCommand(Car car)
        {
            _car = car;
        }

        public void Execute()
        {
            CarGarage.GetCarGarage().Add(_car);
            Console.WriteLine("Car added");
        }
    }
}
