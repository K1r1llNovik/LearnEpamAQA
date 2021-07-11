using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Bus : Vehicle
    {
        private byte _maximumNumberOfPassengers;

        /// <summary>
        /// Get and set maximum number of passengers
        /// </summary>
        public byte MaximumNumberOfPassengers
        {
            get
            {
                return _maximumNumberOfPassengers;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException(nameof(_maximumNumberOfPassengers));
                }
                _maximumNumberOfPassengers = value;
            }
        }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="maximumNumberOfPassengers"></param>
        /// <param name="chassis"></param>
        /// <param name="engine"></param>
        /// <param name="transmission"></param>
        public Bus(byte maximumNumberOfPassengers, Chassis chassis, Engine engine, Transmission transmission) : base(chassis, engine, transmission)
        {
            MaximumNumberOfPassengers = maximumNumberOfPassengers;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Maximum number of passengers: {MaximumNumberOfPassengers}";
        }
    }
}
