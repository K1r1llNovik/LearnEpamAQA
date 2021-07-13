﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    public class Drone : FlyingObject, IFlyable
    {
        /// <summary>
        /// Drone speed, km/h
        /// </summary>
        private const int _speed = 30;

        /// <summary>
        /// The maximum distance that drone can fly, km
        /// </summary>
        private const int _maximumDistance = 1000;

        /// <summary>
        /// Stop time, h
        /// </summary>
        private const double _stopTime = 1 / 60;

        /// <summary>
        /// The period with which the drone stops, h
        /// </summary>
        private const double _stopPeriod = 1 / 6;

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

            if(distance > _maximumDistance)
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

            if (distance > _maximumDistance)
            {
                throw new ArgumentException("Method can't get fly time, becuse drone can't fly this distance");
            }

            DateTime time = DateTime.Now;
            double nonStopTime = distance / _speed;
            double stopTime = nonStopTime / _stopPeriod * _stopTime;
            return time.AddHours(nonStopTime - stopTime);

        }
    }
}
