using System;

namespace OOP
{
    /// <summary>
    /// Class represent engine
    /// </summary>
    [Serializable]
    public class Engine
    {
        /// <summary>
        /// Set and get engine capacity 
        /// </summary>
        public double Capacity { get; set; }

        /// <summary>
        /// Set and get engine volume
        /// </summary>
        public double Volume { get; set; }

        /// <summary>
        /// Set and get engine type
        /// </summary>
        public EngineType Type { get; set; }

        /// <summary>
        /// Set and get engine serial number
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Engine() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="volume"></param>
        /// <param name="type"></param>
        /// <param name="serialNumber"></param>
        public Engine (double capacity, double volume, EngineType type, string serialNumber)
        {
            Capacity = capacity;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }

        /// <summary>
        /// Method which returns all information about engine
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return ("Engine info: " + "Capacity: " + Capacity + "Volume: " + Volume + "Type: " + Type + "Serial number" + SerialNumber);
        }

    }
}
