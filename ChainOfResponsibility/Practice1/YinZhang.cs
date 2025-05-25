using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Practice1
{
    internal class YinZhang : Officer
    {
        public YinZhang(string name) : base(name)
        {
        }

        public override void SendMessage(int enemy)
        {
            if (enemy >= 50 && enemy < 200)
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
