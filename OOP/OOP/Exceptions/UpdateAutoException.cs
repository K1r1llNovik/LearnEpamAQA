using System;

namespace OOP
{
public class UpdateAutoException : Exception
    {
        public UpdateAutoException(int id) : base($"Unable to replace car with this {id}") { }
    }
}
