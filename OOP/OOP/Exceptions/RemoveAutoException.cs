using System;

namespace OOP
{
public class RemoveAutoException : Exception
    {
        public RemoveAutoException(string message) : base(message = "Unable to delete auto whith non - existent id") { }
    }
}
