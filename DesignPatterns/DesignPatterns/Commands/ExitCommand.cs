using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Commands
{
    public class ExitCommand : ICommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
