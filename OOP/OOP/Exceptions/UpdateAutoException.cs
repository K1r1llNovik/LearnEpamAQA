using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Exceptions
{
public class UpdateAutoException : Exception
    {
        public UpdateAutoException() { }
        public UpdateAutoException(string message) : base(message) { }
    }
}
