using System;

namespace CosmosKernel2.Commands
{
    public class GetUsedRAM : Command
    {
        public GetUsedRAM(String name) : base(name) { }
        public override String execute(String[] args)
        {
            Console.WriteLine(Cosmos.Core.GCImplementation.GetUsedRAM()/1024 + "K used");
            return "";
        }

    }
}
