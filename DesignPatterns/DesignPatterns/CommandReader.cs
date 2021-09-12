using System;
using DesignPatterns.Commands;
using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    public class CommandReader
    {
        public ICommand GetCommand(string[] commands)
        {
            ICommand command;

            switch (commands[0])
            {
                case "add":
                    command = GetAddCommand(commands);
                    break;

                case "count":
                    command = GetCountCommand(commands);
                    break;

                case "average":
                    command = GetAverageCommand(commands);
                    break;

                case "commands":
                    command = new ListOfCommands();
                    break;

                case "exit":
                    command = new ExitCommand();
                    break;

                default:
                    command = null;
                    break;
            }

            if (command == null)
            {
                Console.WriteLine("No command");
            }

            return command;
        }

        private ICommand GetAddCommand(string[] args)
        {
            if (args.Length != 5)
            {
                return null;
            }

            Car car = new Car(args[1], args[2], Convert.ToInt32(args[3]), Convert.ToDouble(args[4]));
            return new AddCommand(car);
        }

        private ICommand GetCountCommand(string[] args)
        {
            if (args.Length != 2)
            {
                return null;
            }

            switch (args[1])
            {
                case "types":
                    return new CountTypesCommand();
                case "all":
                    return new CountAllCommand();
                default:
                    return null;
            }
        }

        private ICommand GetAverageCommand(string[] args)
        {
            if (args.Length > 3 && args.Length < 2)
            {
                return null;
            }

            switch (args[1])
            {
                case "price":
                    return GetAveragePriceCommand(args);
                default:
                    return null;
            }
        }

        private ICommand GetAveragePriceCommand(string[] args)
        {
            switch (args.Length)
            {
                case 2:
                    return new AveragePriceCommand();
                case 3:
                    return new AveragePriceTypeCommand(args[2]);
                default:
                    return null;
            }
        }
    }
}
