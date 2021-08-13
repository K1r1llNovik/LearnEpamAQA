using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Exceptions
{
public class RemoveAutoException : Exception
    {
        public RemoveAutoException() { }
        public RemoveAutoException(string message) : base(message) { }
    }
}
