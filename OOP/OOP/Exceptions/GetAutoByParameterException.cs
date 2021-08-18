using System;

namespace OOP
{
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException(string parameter) : base("This parameter does not exist " + parameter) { }
    }
}
