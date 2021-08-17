using System;

namespace OOP
{
    /// <summary>
    /// Class represent Bus
    /// </summary>
    [Serializable]
    public class Bus : Vehicle
    {
        private byte _maximumNumberOfPassengers;

        /// <summary>
        /// Get and set maximum number of passengers
        /// </summary>
        public byte MaximumNumberOfPassengers { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Bus() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="maximumNumberOfPassengers"></param>
        /// <param name="chassis"></param>
        /// <param name="engine"></param>
        /// <param name="transmission"></param>
        public Bus(byte maximumNumberOfPassengers, Chassis chassis, Engine engine, Transmission transmission) 
               : base(chassis, engine, transmission)
        {
            MaximumNumberOfPassengers = maximumNumberOfPassengers;

            if (!IsValidBus())
            {
                throw new ArgumentException("Unable to initilize the bus");
            }
        }

        /// <summary>
        /// Method that return all information about bus
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return base.GetInfo() + $"Maximum number of passengers: {MaximumNumberOfPassengers}";
        }

        /// <summary>
        /// Method which check valid values
        /// </summary>
        /// <returns>True if the values if valid, otherwise false</returns>
        private bool IsValidBus()
        {
            return IsValidVehicle() && MaximumNumberOfPassengers <= 50;
        }
    }
}
