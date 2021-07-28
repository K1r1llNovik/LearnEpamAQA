using System;

namespace InterfacesAndAbstractClasses
{
    public class Plane : FlyingObject, IFlyable
    {
        /// <summary>
        /// Start speed of plain, km/h
        /// </summary>
        private const int StartSpeed = 200;

        /// <summary>
        /// How much speed increases every 10 km of flight, km/h
        /// </summary>
        private const int IncreasedSpeed = 10;

        /// <summary>
        /// What distance is required for the plane to increase speed
        /// </summary>
        private const int IncreaseDistance = 10;

        /// <summary>
        /// Fuel consumtion per 1000 km, kg
        /// </summary>
        private const int FuelConsumption = 1750;

        /// <summary>
        /// Fuel tank, liters
        /// </summary>
        private double FuelCapacity { get; set; }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="fuelCapacity"></param>
        /// <param name="position"></param>
        public Plane(double fuelCapacity, Coordinate position) : base(position)
        {
            FuelCapacity = fuelCapacity;
        }

        /// <summary>
        /// Method that change current position
        /// </summary>
        /// <param name="newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            double distance = Postion.GetDistance(newCoordinate);

            if (distance > FuelCapacity * FuelCapacity / 1000)
            {
                throw new ArgumentException("Not enought fuel");
            }
            else
            {
                Postion = newCoordinate;
            }
        }

        /// <summary>
        /// Method that getting fly time in hours
        /// </summary>
        /// <param name="newCoordinate"></param>
        /// <returns></returns>
        public DateTime GetFlyTime(Coordinate newCoordinate)
        {
            DateTime time = DateTime.Now;
            int speed = StartSpeed;
            double flighTime = 0;
            double distance = Postion.GetDistance(newCoordinate);

            while (distance > 0)
            {
                flighTime += IncreaseDistance / speed;
                speed += IncreasedSpeed;
                distance -= IncreaseDistance;
            }
            flighTime += distance / speed;

            return time.AddHours(flighTime);
        }

    }
}
