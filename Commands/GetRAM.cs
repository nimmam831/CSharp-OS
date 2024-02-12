using System;

namespace CosmosKernel2.Commands
{
    public class GetRAM : Command
    {
        public GetRAM(String name) : base(name) { }
        public override String execute(String[] args)
        {
            Console.WriteLine(Cosmos.Core.GCImplementation.GetAvailableRAM() + "M available");
            return "";
        }

    }
}
