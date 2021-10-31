using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    public class Invoker
    {
        private ICommand _command;

        public void ExecuteCommand(ICommand command)
        {
            if (command == null)
            {
                return;
            }

            _command = command;
            _command.Execute();
        }
    }
}
