using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP
{
    /// <summary>
    /// 
    /// </summary>
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

        /// <summary>
        /// Method which return list of vehicles selected by parameter
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="value"></param>
        /// <returns>List of selected vehicles</returns>
        public List<Vehicle> GetAutoByParameter(string parameter, string value)
        {
            List<Vehicle> selectedVehicles = new List<Vehicle>();
            switch (parameter.ToLower())
            {
                case "enginetype":
                    selectedVehicles = (from v in Vehicles
                                        where v.VehicleEngine.Type.ToString().Equals(value)
                                        select v).ToList();
                    break;

                case "transmissiontype":
                    selectedVehicles = (from v in Vehicles
                                        where v.VehicleTransmission.Type.ToString().Equals(value)
                                        select v).ToList();
                    break;

                case "numberofgears":
                    selectedVehicles = (from v in Vehicles
                                        where v.VehicleTransmission.NumberOfGears.ToString().Equals(value)
                                        select v).ToList();
                    break;

                case "manufacter":
                    selectedVehicles = (from v in Vehicles
                                        where v.VehicleTransmission.Manufacturer.ToString().Equals(value)
                                        select v).ToList();
                    break;

                case "serialnumber":
                    selectedVehicles = (from v in Vehicles
                                        where v.VehicleEngine.SerialNumber.ToString().Equals(value)
                                        select v).ToList();
                    break;

                case "volume":
                    selectedVehicles = (from v in Vehicles
                                        where v.VehicleEngine.Volume.ToString().Equals(value)
                                        select v).ToList();
                    break;

                case "capacity":
                    selectedVehicles = (from v in Vehicles
                                        where v.VehicleEngine.Capacity.ToString().Equals(value)
                                        select v).ToList();
                    break;

                case "numberofwheels":
                    selectedVehicles = (from v in Vehicles
                                        where v.VehicleChassis.NumberOfWheels.ToString().Equals(value)
                                        select v).ToList();
                    break;

                case "PermissibleLoad":
                    selectedVehicles = (from v in Vehicles
                                        where v.VehicleChassis.PermissibleLoad.ToString().Equals(value)
                                        select v).ToList();
                    break;
                default:
                    throw new GetAutoByParameterException("This parameter does not exist");
            }
            return selectedVehicles;
        }

        /// <summary>
        /// Method which replaces the old vehicle with a new one
        /// </summary>
        /// <param name="id"></param>
        /// <param name="vehicle"></param>
        public void UpdateAuto(int id, Vehicle vehicle)
        {
            if (id<0 || id >= Vehicles.Count)
            {
                throw new UpdateAutoException("Unable to replace");
            }

            Vehicles[id] = vehicle;
        }

        /// <summary>
        /// Method which remove auto by id
        /// </summary>
        /// <param name="id"></param>
        public void RemoveAuto(int id)
        {
            if (id < 0 || id >= Vehicles.Count)
            {
                throw new RemoveAutoException("Unable to delete auto whith non-existent id");
            }
            Vehicles.RemoveAt(id);
        }
    }
}
