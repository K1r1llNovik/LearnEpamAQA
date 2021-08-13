using System;

namespace OOP.Exceptions
{
    public class InitializationException : Exception
    { 

        public InitializationException() { }
        public InitializationException(string message) : base(message) { }
    }
}
