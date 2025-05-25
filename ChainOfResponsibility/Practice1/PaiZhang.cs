using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Practice1
{
    internal class PaiZhang : Officer
    {
        public PaiZhang(string name) : base(name)
        {
        }

        public override void SendMessage(int enemy)
        {
            if (enemy >= 10 && enemy<50)
            {
                Console.WriteLine($"敵人數量{enemy}，{this.Name}下達作戰指令");
            }
            else
            {
                this.successor.SendMessage(enemy);
            }
        }
    }
}
