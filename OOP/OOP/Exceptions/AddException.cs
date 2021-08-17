using System;


namespace OOP
{
    public class AddException : Exception
    {
        public AddException() { }
        public AddException(string message) : base(message) { }
    }
}