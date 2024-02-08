using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using CosmosKernel2.Commands;
using Cosmos.System.FileSystem;

namespace CosmosKernel2
{
    public class Kernel : Sys.Kernel
    {

        private CommandManager commandManager;
        private CosmosVFS vfs;

        protected override void BeforeRun()
        {
            this.vfs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            this.commandManager = new CommandManager();
            Console.Beep();
            Console.WriteLine("Cosmos booted successfully. Type a command to run it.");
        }

        protected override void Run()
        {
            String response;
            String input = Console.ReadLine();
            response = this.commandManager.processInput(input);
            Console.WriteLine(response);
        }
    }
}
