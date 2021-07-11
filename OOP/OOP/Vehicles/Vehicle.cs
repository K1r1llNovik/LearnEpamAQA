using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    /// <summary>
    /// Abstract class for defining vehicles
    /// </summary>
    abstract class Vehicle
    {
        /// <summary>
        /// Get and Set chassis
        /// </summary>
        public Chassis VehicleChassis { get; set; }

        /// <summary>
        /// Get and set engine
        /// </summary>
        public Engine VehicleEngine { get; set; }

        /// <summary>
        /// Get and set transmission
        /// </summary>
        public Transmission VehicleTransmission { get; set; }

        /// <summary>
        /// Constructor initialisez class fields
        /// </summary>
        /// <param name="vehicleChassis"></param>
        /// <param name="vehicleEngine"></param>
        /// <param name="vehicleTransmissin"></param>
        public Vehicle(Chassis vehicleChassis, Engine vehicleEngine, Transmission vehicleTransmissin)
        {
            VehicleChassis = vehicleChassis;
            VehicleEngine = vehicleEngine;
            VehicleTransmission = vehicleTransmissin;
        }

        /// <summary>
        /// Method that returns all informtaion about the vehicles
        /// </summary>
        /// <returns></returns>
        virtual public string GetInfo()
        {
            return $"{VehicleEngine.GetInfo()}/n" + $"{VehicleChassis.GetInfo()}/n" + $"{ VehicleTransmission.GetInfo()}/n";
        }
    }
}
