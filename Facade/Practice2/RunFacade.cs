using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Practice2
{
    internal class RunFacade
    {
        private CPU cpu;
        private HDD HDD;
        private Memory memory;
        private OS OS;

        public RunFacade() 
        {
            cpu = new CPU();
            memory = new Memory();
            OS = new OS();
            HDD = new HDD();
        }

        public void ExecuteOS() 
        {
            cpu.Run();
            memory.Check();
            HDD.Read();
            OS.Load();
            Console.Write("主機已啟動");
        }
    }
}
