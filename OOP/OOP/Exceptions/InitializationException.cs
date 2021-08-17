using System;

namespace OOP
{
    public class InitializationException : Exception
    { 

        public InitializationException() { }
        public InitializationException(string message) : base(message) { }
    }
}
