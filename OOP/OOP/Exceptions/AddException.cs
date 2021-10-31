using System;

namespace OOP
{
    public class AddException : Exception
    {
        public AddException (Vehicle vehicle) : base("Unable to add car model" + vehicle.GetInfo()) { }
    }
}