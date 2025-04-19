using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice1
{
    internal class NoteBook : ComputerBuilder
    {
        public override void BuildCPU()
        {
            computer.CPU = "NoteBook CPU";
        }

        public override void BuildDisk()
        {
            computer.Disk = "NoteBook Disk";
        }

        public override void BuildMemory()
        {
            computer.Memory = "NoteBook Memory";
        }

        public override void BuildScreen()
        {
            computer.Screen = "NoteBook Screen";
        }
    }
}
