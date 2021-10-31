using System;

namespace InterfacesAndAbstractClasses
{
    public class Drone : FlyingObject, IFlyable
    {
        /// <summary>
        /// Drone speed, km/h
        /// </summary>
        private const int Speed = 30;

        /// <summary>
        /// The maximum distance that drone can fly, km
        /// </summary>
        private const int MaximumDistance = 1000;

        /// <summary>
        /// Stop time, h
        /// </summary>
        private const double StopTime = 1 / 60;

        /// <summary>
        /// The period with which the drone stops, h
        /// </summary>
        private const double StopPeriod = 1 / 6;

        /// <summary>
        /// Constructor initializes class field
        /// </summary>
        /// <param name="position"></param>
        public Drone(Coordinate position) : base(position) { }

        /// <summary>
        /// Method that change current position
        /// </summary>
        /// <param name="newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            double distance = Postion.GetDistance(newCoordinate);

            if(distance > MaximumDistance)
            {
                throw new ArgumentException("Drone can't fly this distance");
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
            double distance = Postion.GetDistance(newCoordinate);

            if (distance > MaximumDistance)
            {
                throw new ArgumentException("Method can't get fly time, becuse drone can't fly this distance");
            }

            double nonStopTime = distance / Speed;
            double stopTime = nonStopTime * StopPeriod * StopTime;
            double currentTime = nonStopTime - stopTime;
            DateTime time = DateTime.Now;

            return time.AddHours(currentTime);
        }
    }
}
