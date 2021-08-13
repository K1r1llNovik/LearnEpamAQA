using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Exceptions
{
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException() { }
        public GetAutoByParameterException(string message) : base(message) { }
    }
}
