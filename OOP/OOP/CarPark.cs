using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP
{
    public class CarPark
    {
        public List<Vehicle> Vehicles { get; set; }

        /// <summary>
        /// Constructor initilize class fields
        /// </summary>
        /// <param name="vehicles"></param>
        public CarPark(List<Vehicle> vehicles)
        {
            Vehicles = vehicles;
        }

        /// <summary>
        /// Add vehicle to the collection
        /// </summary>
        /// <param name="vehicle"></param>
        public void Add(Vehicle vehicle)
        {
            if (IsContains(vehicle))
            {
                throw new AddException("Unable to add car model");
            }

            Vehicles.Add(vehicle);
        }

        /// <summary>
        /// Determines if the collection contains an object
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        private bool IsContains(Vehicle vehicle)
        {
            return Vehicles.Select(v => v.Equals(vehicle)).Contains(true);
        }
    }
}
