using System;

namespace OOP
{
    public class InitializationException : Exception
    { 
        public InitializationException() : base("Unable to initilize") { }
    }
}
