using System;

namespace CosmosKernel2.Commands
{
    public class Help : Command
    {
        public Help (String name) : base (name) { }
        public override string execute(string[] args)
        {
            Console.WriteLine("UnkOS 1.0 Help");
            Console.WriteLine("Commands:");
            Console.WriteLine("beep - Plays a 90ms 500 Hz beep");
            Console.WriteLine("echo - Outputs what is typed in after echo.");
            Console.WriteLine("file - File reading, writing, deleting and creating command");
            Console.WriteLine("file create - Creates a file");
            Console.WriteLine("file createdir - Creates a directory");
            Console.WriteLine("file remove - Removes a file");
            Console.WriteLine("file rmdir - Removes a directory");
            Console.WriteLine("file writestr - Writes to a file");
            Console.WriteLine("file readstr - Reads the first 256 bytes of a file");
            Console.WriteLine("getram - Outputs the amount of RAM available to use");
            Console.WriteLine("getusedram - Outputs the amount of RAM used");
            Console.WriteLine("help - Gives a list of UnkOS commands");
            Console.WriteLine("launchgui - Outputs the amount of RAM used");
            return "Command executed successfully.";
        }

    }
}
