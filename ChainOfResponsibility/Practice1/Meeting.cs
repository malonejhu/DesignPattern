using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Practice1
{
    internal class Meeting : Officer
    {
        public Meeting(string name) : base(name)
        {
        }

        public override void SendMessage(int enemy)
        {
            Console.WriteLine($"敵人數量{enemy}，{this.Name}下達作戰指令");
        }
    }
}
