using System;
using CosmosKernel2.Graphics;

namespace CosmosKernel2.Commands
{
    public class LaunchGUI : Command
    {
        public LaunchGUI(String name) : base(name) { }
        public override String execute(String[] args)
        {
            if (Kernel.gui != null)
            {
                return "GUI already launched.";
            }
            Kernel.gui = new GUI();
            return "If you are seeing this for some time, try restarting UnkOS unless it started.";
        }

    }
}
