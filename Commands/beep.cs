using System;

namespace CosmosKernel2.Commands
{
    public class beep : Command
    {
        public beep(String name) : base(name) { }
        public override String execute(String[] args)
        {
            Console.Beep(500, 90);
            return "Command executed successfully";
        }

    }
}
