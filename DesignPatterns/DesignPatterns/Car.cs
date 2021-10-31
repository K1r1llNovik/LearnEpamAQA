using System;

namespace DesignPatterns
{
    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int CountOfCar { get; set; }

        public double PriceOfOne { get; set; }

        public Car (string brand, string model, int countOfCar, double priceOfOne)
        {
            Brand = brand;
            Model = model;
            CountOfCar = countOfCar;
            PriceOfOne = priceOfOne;
        }
    }
}
