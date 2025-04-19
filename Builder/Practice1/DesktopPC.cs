using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice1
{
    internal class DesktopPC : ComputerBuilder
    {
        public override void BuildCPU()
        {
            computer.CPU = "Desktop CPU";
        }

        public override void BuildDisk()
        {
            computer.Disk = "Desktop Disk";
        }

        public override void BuildMemory()
        {
            computer.Memory = "Desktop Memory";
        }

        public override void BuildScreen()
        {
            computer.Screen = "Desktop Screen";
        }
    }
}
