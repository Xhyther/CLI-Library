using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotationTranslator.Cmd
{
    public class CommandInvoker
    {
        public static async Task InvokeAsync(Command rootCommand, string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No command provided.");
                return;
            }

            var currentCommand = rootCommand;
            int i = 0;

            // Walk through subcommands
            while (i < args.Length && currentCommand.Subcommands.Any())
            {
                var next = currentCommand.Subcommands.FirstOrDefault(cmd => cmd.Name == args[i]);
                if (next == null) break;

                currentCommand = next;
                i++;
            }

            // Parse options
            var options = new Dictionary<string, string>();
            while (i < args.Length)
            {
                var arg = args[i];
                if (arg.StartsWith("--") && i + 1 < args.Length)
                {
                    options[arg.Substring(2)] = args[i + 1];
                    i += 2;
                }
                else
                {
                    i++;
                }
            }

            if (currentCommand.Handler != null)
            {
                await currentCommand.Handler(options);
            }
            else
            {
                Console.WriteLine($"No handler for command: {currentCommand.Name}");
            }
        }
    }
}
