using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosKernel2.Commands
{
    public class CommandManager
    {
        private List<Command> commands;

        public CommandManager() {
            this.commands = new List<Command>(2);
            this.commands.Add(new Help("help"));
            this.commands.Add(new beep("beep"));
            this.commands.Add(new File("file"));
            this.commands.Add(new echo("echo"));
        }

        public String processInput(String input)
        {
            //Example: echo hello this is a test
            String[] split = input.Split(' ');
            /*
                 * echo
                 * hello
                 * this
                 * is
                 * a
                 * test
            */
            String label = split[0];
            List<String> args = new List<String>();
            int ctr = 0;
            foreach (String s in split)
            {
                if (ctr!=0)
                {
                    args.Add(s);
                }
                ++ctr;
            }
            //label = echo
            foreach (Command cmd in this.commands)
            {
                if (cmd.name.ToLower()==label.ToLower())
                {
                    return cmd.execute(args.ToArray());
                }
            }
            return "Invalid command \""+label+"\", please use help command.";
        }
    }
}
