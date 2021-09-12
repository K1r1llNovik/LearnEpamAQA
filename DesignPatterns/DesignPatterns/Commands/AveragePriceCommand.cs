using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Commands
{
    public class AveragePriceCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine(CarGarage.GetCarGarage().GetAveragePrice());
        }
    }
}
