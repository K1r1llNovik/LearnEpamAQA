using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Commands
{
    public class AveragePriceTypeCommand : ICommand
    {
        private string _brand;

        public AveragePriceTypeCommand(string brand)
        {
            _brand = brand;
        }
        public void Execute()
        {
            Console.WriteLine(CarGarage.GetCarGarage().GetAveragePriceType(_brand));
        }
    }
}
