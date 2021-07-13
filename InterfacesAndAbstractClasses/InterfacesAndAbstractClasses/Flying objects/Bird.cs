using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    class Bird : FlyingObject, IFlyable
    {
        /// <summary>
        /// Minimum speed, km/h
        /// </summary>
        private const int _minimalSpeed = 0;

        /// <summary>
        /// Maximum speed, km/h
        /// </summary>
        private const int _maximumSpeed = 20;

        /// <summary>
        /// Maximum flying distance, km
        /// </summary>
        private const int _maximumDistance = 100;

        /// <summary>
        /// Get and set speed of bird
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Constructor initialize class field
        /// </summary>
        /// <param name="position"></param>
        public Bird(Coordinate position) : base(position)
        {
            Random randomSpeed = new Random();
            Speed = randomSpeed.Next(_minimalSpeed, _maximumSpeed);
        }

        /// <summary>
        /// Method that change current position
        /// </summary>
        /// <param name="newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            double distance = Postion.GetDistance(newCoordinate);

            if (distance > _maximumDistance)
            {
                throw new ArgumentException("Bird can't fly this distance");
            }
            else
            {
                Postion = newCoordinate;
            }
        }

        /// <summary>
        /// Method for getting fly time
        /// </summary>
        /// <param name="newCoordinate"></param>
        /// <returns></returns>
        public DateTime GetFlyTime(Coordinate newCoordinate)
        {
            if (Speed == _minimalSpeed)
            {
                throw new ArgumentException("Speed cannot be equal 0");
            }
            else
            {
                DateTime time = DateTime.Now;
                return time.AddHours(Postion.GetDistance(newCoordinate) / Speed);
            }
        }
    }
}
