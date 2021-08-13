using System;


namespace OOP.Exceptions
{
    public class AddException : Exception
    {
        public AddException() { }
        public AddException(string message) : base(message) { }
    }
}