using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    /// <summary>
    /// Class which contains methods for filtrating list of vehicles
    /// </summary>
    public static class Filtration
    {
        /// <summary>
        /// Method that return list of vehicles that contain vehicles with engine capacity more than given capacity
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="vehicles"></param>
        /// <returns></returns>
        public static List<Vehicle> GetListOfVehiclesWithEngineVolumeMoreThan(double volume, List<Vehicle> vehicles)
        {
            return vehicles.Where(v => v.VehicleEngine.Volume > volume).ToList();
        }

        /// <summary>
        /// Method that return list of engines of truck and bus
        /// </summary>
        /// <param name="vehicles"></param>
        /// <returns></returns>
        public static List<Engine> GetListOfEngineInfoOfBusAndTruck(List<Vehicle> vehicles)
        {
            return vehicles.Where(v => v is Bus || v is Truck).Select(x => x.VehicleEngine).ToList();
        }

        /// <summary>
        /// Method that return list of vehicles grouped by transmission
        /// </summary>
        /// <param name="vehicles"></param>
        /// <returns></returns>
        public static List<Vehicle> GetListOfVehiclesGroupByTransmission(List<Vehicle> vehicles)
        {
            return vehicles.GroupBy(x => x.VehicleTransmission.Type).SelectMany(x => x).ToList();
        }
    }
}
