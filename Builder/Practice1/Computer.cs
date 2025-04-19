using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice1
{
    internal class Computer
    {
        private string cpu;
        private string memory;
        private string disk;
        private string screen;

        public string CPU 
        {
            get { return cpu; }
            set { cpu = value; }
        }


        public string Memory
        {
            get { return memory; }
            set { memory = value; }
        }


        public string Disk
        {
            get { return disk; }
            set { disk = value; }
        }


        public string Screen
        {
            get { return screen; }
            set { screen = value; }
        }

    }
}
