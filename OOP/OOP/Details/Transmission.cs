using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Transmission
    {
        /// <summary>
        /// Get and set transmission types
        /// </summary>
        public TransmissionType Type { get; set; }

        /// <summary>
        /// Get and set number if Gears
        /// </summary>
        public byte NumberOfGears { get; set; }

        /// <summary>
        /// Get and set manufacturer of transmission
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="type"></param>
        /// <param name="numberOfGears"></param>
        /// <param name="manufacturer"></param>
        public Transmission(TransmissionType type, byte numberOfGears, string manufacturer)
        {
            Type = type;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        /// <summary>
        /// Method that return all information about transmission
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return ("Transmission info: " + "Type: " + Type + "Number of gears: " + NumberOfGears + "Manufacturer: " + Manufacturer);
        }

    }
}
