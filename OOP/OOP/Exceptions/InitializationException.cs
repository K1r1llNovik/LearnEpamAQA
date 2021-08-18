using System;

namespace OOP
{
    public class InitializationException : Exception
    { 
        public InitializationException(string message) : base(message = "Unable to initilize") { }
    }
}
