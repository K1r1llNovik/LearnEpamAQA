using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP
{
    public class CarPark
    {
        public List<Vehicle> Vehicles { get; set; }

        public CarPark(List<Vehicle> vehicles)
        {
            Vehicles = vehicles;
        }
    }
}
