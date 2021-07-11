using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Car: Vehicle
    {
        private byte _numberOfDoors;

        /// <summary>
        /// Set and get number of doors
        /// </summary>
        public byte NumberOfDoors
        {
            get
            {
                return _numberOfDoors;
            }

            set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentException(nameof(_numberOfDoors));
                }
                _numberOfDoors = value;
            }
        }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="numberOfDoors"></param>
        /// <param name="chassis"></param>
        /// <param name="engine"></param>
        /// <param name="transmission"></param>
        public Car(byte numberOfDoors, Chassis chassis, Engine engine, Transmission transmission) : base(chassis, engine, transmission)
        {
            NumberOfDoors = numberOfDoors;
        }

        /// <summary>
        /// Method that returns all information about car
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return base.GetInfo() + $"Number of doors: {NumberOfDoors}";
        }
    }
}
