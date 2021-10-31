using System;
using DesignPatterns.Commands;

namespace DesignPatterns.Interfaces
{
    public class CountTypesCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine(CarGarage.GetCarGarage().GetCountTypes());
        }
    }
}
