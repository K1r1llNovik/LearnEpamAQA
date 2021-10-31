using System;

namespace OOP
{
public class RemoveAutoException : Exception
    {
        public RemoveAutoException(int id) : base($"Unable to delete auto whith non - existent {id}") { }
    }
}
