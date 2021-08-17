using System;

namespace OOP
{
public class RemoveAutoException : Exception
    {
        public RemoveAutoException() { }
        public RemoveAutoException(string message) : base(message) { }
    }
}
