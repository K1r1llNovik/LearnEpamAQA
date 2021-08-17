using System;
using System.Xml.Serialization;

namespace OOP
{
    /// <summary>
    /// Abstract class for defining vehicles
    /// </summary>
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Scooter))]
    [Serializable]
    public abstract class Vehicle
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
        /// Default constructor
        /// </summary>
        protected Vehicle() { }

        /// <summary>
        /// Constructor initialisez class fields
        /// </summary>
        /// <param name="vehicleChassis"></param>
        /// <param name="vehicleEngine"></param>
        /// <param name="vehicleTransmissin"></param>
        protected Vehicle(Chassis vehicleChassis, Engine vehicleEngine, Transmission vehicleTransmission)
        {
            VehicleChassis = vehicleChassis;
            VehicleEngine = vehicleEngine;
            VehicleTransmission = vehicleTransmission;
        }

        /// <summary>
        /// Method that returns all informtaion about the vehicles
        /// </summary>
        /// <returns></returns>
        public virtual string GetInfo()
        {
            return $"{VehicleEngine.GetInfo()}/n" + $"{VehicleChassis.GetInfo()}/n" + $"{ VehicleTransmission.GetInfo()}/n";
        }

        /// <summary>
        /// Method which check valid values in vehicle
        /// </summary>
        /// <returns>Return true if the values are valid, otherwise false</returns>
        protected bool IsValidVehicle()
        {
            return !(VehicleChassis is null || VehicleEngine is null || VehicleTransmission is null);
        }
    }
}
