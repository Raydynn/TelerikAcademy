using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleApplication3
{
    class Engine
    {
        private ConsoleReaderProvider reader;

        public Engine(ConsoleReaderProvider reader)
        {
            this.reader = reader;
        }

        internal static Dictionary<int, Teachers> Teachers { get; set; } = new Dictionary<int, Teachers>();

        internal static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();

        public void EngineStart()
        {
            while (true)
            {
                try
                {
                    var cmd = System.Console.ReadLine();
                    if (cmd == "End")
                    {
                        break;
                    }

                    var commandName = cmd.Split(' ')[0];

                    var assembly = GetType().GetTypeInfo().Assembly;
                    var typeInfo = assembly.DefinedTypes
                        .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                        .Where(type => type.Name.ToLower().Contains(commandName.ToLower()))
                        .FirstOrDefault();

                    if (typeInfo == null)
                    {
                        throw new ArgumentException("The passed command is not found!");
                    }

                    var command = Activator.CreateInstance(typeInfo) as ICommand;
                    var parameters = cmd.Split(' ').ToList();
                    parameters.RemoveAt(0);
                    Console.WriteLine(command.Execute(parameters));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
