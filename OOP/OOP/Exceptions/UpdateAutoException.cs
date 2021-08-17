using System;

namespace OOP
{
public class UpdateAutoException : Exception
    {
        public UpdateAutoException() { }
        public UpdateAutoException(string message) : base(message) { }
    }
}
