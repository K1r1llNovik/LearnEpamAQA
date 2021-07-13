using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    public abstract class FlyingObject
    {
        /// <summary>
        /// Method that get and set current postion of flying object
        /// </summary>
        public Coordinate Postion { get; set; }

        /// <summary>
        /// Constructor for flying object
        /// </summary>
        /// <param name="position"></param>
        public FlyingObject(Coordinate position)
        {
            Postion = position;
        }


    }
}
