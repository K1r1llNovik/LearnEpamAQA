using System;

namespace OOP
{
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException(string message) : base(message = "This parameter does not exist") { }
    }
}
