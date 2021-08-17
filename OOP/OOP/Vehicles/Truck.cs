using System;

namespace OOP
{
    [Serializable]
    public class Truck : Vehicle
    {
        private double _maximumLiftingCapacity;

        /// <summary>
        /// Get and set maximum lifting capacity
        /// </summary>
        public double MaximumLiftingCapacity
        {
            get
            {
                return _maximumLiftingCapacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(_maximumLiftingCapacity));
                }
                _maximumLiftingCapacity = value;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Truck() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="maximumLiftingCapacity"></param>
        /// <param name="chassis"></param>
        /// <param name="engine"></param>
        /// <param name="transmission"></param>
        public Truck(double maximumLiftingCapacity, Chassis chassis, Engine engine, Transmission transmission) 
               : base(chassis, engine, transmission)
        {
            MaximumLiftingCapacity = _maximumLiftingCapacity;
            if (!IsValidTruck())
            {
                throw new InitializationException("Unable to initilize the truck");
            }
        }

        /// <summary>
        /// Method that returns all information about Truck
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return base.GetInfo() + $"Maximum lifting capacity: {MaximumLiftingCapacity}";
        }

        /// <summary>
        /// Method which check valid values
        /// </summary>
        /// <returns>True if the values if valid, otherwise false</returns>
        private bool IsValidTruck()
        {
            return IsValidVehicle() && MaximumLiftingCapacity > 0 && MaximumLiftingCapacity <= 15000;
        }
    }
}
