using System;
using System.Collections.Generic;

namespace ScriptLanguage
{
    class Program
    {
        static Dictionary<string, string> variables = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            string[] commands = {
                "Write 'Hello.'",
                "message = Read",
                "Write message"
            };

            foreach (string command in commands)
            {
                ExecuteCommand(command);
            }
        }

        static void ExecuteCommand(string command)
        {
            string[] parts = command.Split(' ');

            if (parts[0] == "Write")
            {
                if (parts[1].StartsWith("'"))
                {
                    Console.Write(parts[1].Trim('\''));
                }
                else
                {
                    Console.Write(variables[parts[1]]);
                }
            }
            else if (parts[1] == "=")
            {
                if (parts[2] == "Read")
                {
                    variables[parts[0]] = Console.ReadLine();
                }
            }
        }
    }
}