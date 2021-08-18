using System;

namespace OOP
{
    public class AddException : Exception
    {
        public AddException(string message) : base(message = "Unable to add car model") { }
    }
}