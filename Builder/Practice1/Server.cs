using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice1
{
    internal class Server : ComputerBuilder
    {
        public override void BuildCPU()
        {
            computer.CPU = "Server CPU";
        }

        public override void BuildDisk()
        {
            computer.Disk = "Server Disk";
        }

        public override void BuildMemory()
        {
            computer.Memory = "Server Memory";
        }

        public override void BuildScreen()
        {
            computer.Screen = "沒螢幕";
        }
    }
}
