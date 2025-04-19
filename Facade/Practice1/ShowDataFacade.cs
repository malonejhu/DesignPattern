using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Practice1
{
    internal class ShowDataFacade : AbstractFacade
    {
        private ReadExcel ReadExcel;
        public ShowDataFacade() 
        {
            ReadExcel= new ReadExcel();
        }

        public override void Show()
        {
            ReadExcel.Read();
            Console.WriteLine("顯示報表");
        }
    }
}
