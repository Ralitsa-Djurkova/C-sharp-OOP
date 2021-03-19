using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterptreter : ICommandInterpreter
    {
        private const string CommandPostFix = "Command";
        public string Read(string args)
        {
            string[] tokens = args.Split();

            string commandName = tokens[0];
            string commandTypeName = commandName + CommandPostFix;

           
            Type commandType = Assembly.GetCallingAssembly().GetTypes()
                .Where(t => t.GetInterfaces()
                .Any(i => i.Name == nameof(ICommand)))
                .FirstOrDefault(t => t.Name == commandTypeName);

            if(commandType == null)
            {
                throw new InvalidOperationException("Command type is invalid!");
            }

            ICommand command = Activator.CreateInstance(commandType) as ICommand;
           
            string[] clearData = tokens.Skip(1).ToArray();
            string res = command.Execute(clearData);

            return res;
            
            //string[] tokens = args.Split();
            //string commandName = tokens[0];
            //ICommand command = null;
            //if (commandName == "Hello")
            //{
            //    command = new HelloCommand();
            //}
            //else if(commandName == "Exit")
            //{
            //    command = new ExitCommand();
            //}
            //else if(commandName == "Bye")
            //{
            //    command = new ByCommand();
            //}
            //else
            //{
            //    throw new InvalidOperationException("Invalid command name!");
            //}
            //string[] clearData = tokens.Skip(1).ToArray();
            //string res = command.Execute(clearData);

            //return res;
        }
    }
}
