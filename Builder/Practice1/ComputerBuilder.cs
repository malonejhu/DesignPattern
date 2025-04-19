using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice1
{
    internal abstract class ComputerBuilder
    {
        protected Computer computer = new Computer();

        public abstract void BuildCPU();
        public abstract void BuildMemory();
        public abstract void BuildDisk();
        public abstract void BuildScreen();



        public Computer CreateComputer() 
        {
            this.BuildCPU();
            this.BuildMemory();
            this.BuildDisk();
            this.BuildScreen();

            return computer;
        }
    }
}
