using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    public struct Coordinate
    {
        private double _x;
        private double _y;
        private double _z;

        /// <summary>
        /// Constructor for structure coordinate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Coordinate(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        /// <summary>
        /// Method that calculeted distance between 2 point
        /// </summary>
        /// <param name="coordinate">Coordinate of the second point</param>
        /// <returns></returns>
        public double GetDistance(Coordinate coordinate)
        {
            return Math.Sqrt(Math.Abs(Math.Pow(coordinate._x - _x, 2) + Math.Pow(coordinate._y - _y, 2) + Math.Pow(coordinate._z - _z, 2)));
        }


    }
}
