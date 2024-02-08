using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.IO;
namespace CosmosKernel2.Commands
{
    public class File : Command
    {

        public File (String name) : base (name) { }

        public override String execute(String[] args)
        {
            String response = "";
            //file create test.bin
            switch (args[0]) {
                case "create":
                    {
                        try
                        {
                            Sys.FileSystem.VFS.VFSManager.CreateFile(args[1]);
                            response = "File " + args[1] + " created.";
                            break;
                        }
                        catch (Exception ex) {
                            response = "File creation failure! Exception " + ex.ToString();
                            break;
                        }
                    }
                case "delete":
                    {
                        try
                        {
                            Sys.FileSystem.VFS.VFSManager.DeleteFile(args[1]);
                            response = "File " + args[1] + " deleted.";
                            break;
                        }
                        catch (Exception ex)
                        {
                            response = "File deletion failure! Exception " + ex.ToString();
                            break;
                        }
                    }
                case "createdir":
                    {
                        try
                        {
                            Sys.FileSystem.VFS.VFSManager.CreateDirectory(args[1]);
                            response = "Directory " + args[1] + " created.";
                            break;
                        }
                        catch (Exception ex)
                        {
                            response = "Directory creation failure! Exception " + ex.ToString();
                            break;
                        }
                    }
                case "rmdir":
                    {
                        try
                        {
                            Sys.FileSystem.VFS.VFSManager.DeleteDirectory(args[1], true);
                            response = "Directory " + args[1] + " deleted.";
                            break;
                        }
                        catch (Exception ex)
                        {
                            response = "Directory deletion failure! Exception " + ex.ToString();
                            break;
                        }
                    }
                case "writestr":
                {
                        //file writestr 0:/test.bin Testing
                        try
                        {
                            FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();

                            if (fs.CanWrite)
                            {
                                int ctr = 0;
                                StringBuilder sb = new StringBuilder();
                                foreach (String s in args)
                                {
                                    if (ctr>1)
                                    {
                                        sb.Append(s+' ');
                                    }

                                    ctr++;
                                }
                                Byte[] data = Encoding.ASCII.GetBytes(sb.ToString().Substring(0, sb.ToString().Length-1));
                                fs.Write(data, 0, data.Length);
                                fs.Close();
                                response = "Written successfully";
                                break;
                            } else
                            {
                                response = "Unable to write to file. Is it in use?";
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            response = "Writing failure " + ex.ToString();
                            break;
                        }
                
                }
                case "readstr":
                    {
                        try
                        {
                            FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();
                            if (fs.CanRead) {
                                Byte[] data = new Byte[256];
                                fs.Read(data, 0, data.Length);
                                response = Encoding.ASCII.GetString(data);
                                break;
                            }
                            else
                            {
                                response = "Unable to read from file. Is it open for reading?";
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            response = "Reading failure " + ex.ToString();
                            break;
                        }
                    }
                default:
                { 
                response = "Unexpected argument " + args[0];
                break;
                }
            }
            return response;
        }
    }
}
