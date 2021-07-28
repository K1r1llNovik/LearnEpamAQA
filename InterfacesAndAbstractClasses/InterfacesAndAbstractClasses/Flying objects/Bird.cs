using System;

namespace InterfacesAndAbstractClasses
{
    class Bird : FlyingObject, IFlyable
    {
        /// <summary>
        /// Minimum speed, km/h
        /// </summary>
        private const int MinimalSpeed = 0;

        /// <summary>
        /// Maximum speed, km/h
        /// </summary>
        private const int MaximumSpeed = 20;

        /// <summary>
        /// Maximum flying distance, km
        /// </summary>
        private const int MaximumDistance = 100;

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
            Speed = randomSpeed.Next(MinimalSpeed, MaximumSpeed);
        }

        /// <summary>
        /// Method that change current position
        /// </summary>
        /// <param name="newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            double distance = Postion.GetDistance(newCoordinate);

            if (distance > MaximumDistance)
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
            if (Speed == MinimalSpeed)
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
