using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Practice1
{
    internal class ShowDataFacade2 : AbstractFacade
    {
        private ReadExcel ReadExcel;
        private ConvertData ConvertData;
        public ShowDataFacade2()
        {
            ReadExcel = new ReadExcel();
            ConvertData = new ConvertData();
        }

        public override void Show()
        {
            ReadExcel.Read();
            ConvertData.ToXML();
            Console.WriteLine("顯示報表");
        }
    }
}
