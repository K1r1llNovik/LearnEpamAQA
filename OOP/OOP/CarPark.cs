using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

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
                throw new AddException(vehicle);
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
            if (GetNumberOfAutoWithParameter(parameter) == 0)
            {
                throw new GetAutoByParameterException(parameter);
            }

            return Vehicles.Where(v => GetPropertyValue(parameter, v).Equals(value)).ToList();
        }

        /// <summary>
        /// return property of the class object
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        private PropertyInfo GetPropertyByName(string parameter, Vehicle vehicle)
        {
            return vehicle.GetType().GetProperty(parameter);
        }

        /// <summary>
        /// return property value of the class object
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        private string GetPropertyValue(string parameter, Vehicle vehicle)
        {
            PropertyInfo property = GetPropertyByName(parameter, vehicle);
            if(property is null)
            {
                return null;
            }

            return property.GetValue(vehicle).ToString();
        }

        /// <summary>
        /// Get number of auto with same parameter
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private int GetNumberOfAutoWithParameter(string parameter)
        {
            return Vehicles.Select(v => GetPropertyByName(parameter, v)).Count(p => !(p is null));
        }

        /// <summary>
        /// Method which replaces the old vehicle with a new one
        /// </summary>
        /// <param name="id"></param>
        /// <param name="vehicle"></param>
        public void UpdateAuto(int id, Vehicle vehicle)
        {
            if (id < 0 || id >= Vehicles.Count)
            {
                throw new UpdateAutoException(id);
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
                throw new RemoveAutoException(id);
            }
            Vehicles.RemoveAt(id);
        }
    }
}
