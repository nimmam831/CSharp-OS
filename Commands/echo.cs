using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosmosKernel2.Commands
{
    public class echo : Command
    {
        public echo(String name) : base(name) { }
        public override String execute(String[] args)
        {
            StringBuilder sb = new StringBuilder();
            foreach (String s in args)
            {
                    sb.Append(s + ' ');

            }
            return (String)sb.ToString()    ;
        }

    }
}
