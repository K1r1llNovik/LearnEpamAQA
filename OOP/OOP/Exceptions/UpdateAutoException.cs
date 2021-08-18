using System;

namespace OOP
{
public class UpdateAutoException : Exception
    {
        public UpdateAutoException(string message) : base(message = "Unable to replace") { }
    }
}
