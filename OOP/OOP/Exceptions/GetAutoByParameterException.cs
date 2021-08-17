using System;

namespace OOP
{
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException() { }
        public GetAutoByParameterException(string message) : base(message) { }
    }
}
