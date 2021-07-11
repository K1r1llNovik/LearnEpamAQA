using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Chassis
    {
        /// <summary>
        /// Set and get number of wheels in Chassis
        /// </summary>
        public byte NumberOfWheels { get; set; }

        /// <summary>
        /// Set and get serial number in Chassis
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Set and get permissible load in Chassis
        /// </summary>
        public double PermissibleLoad { get; set; }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="numberOfWheels"></param>
        /// <param name="serialNumber"></param>
        /// <param name="permissibleLoad"></param>
        public Chassis(byte numberOfWheels, string serialNumber, double permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            SerialNumber = serialNumber;
            PermissibleLoad = permissibleLoad;
        }

        /// <summary>
        /// Method that returns all information about chassis
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return ("Chassis information: " + "Number of wheels: " + NumberOfWheels + "Serial number: " + SerialNumber + "Permissible load" + PermissibleLoad);
        }
    }
}
