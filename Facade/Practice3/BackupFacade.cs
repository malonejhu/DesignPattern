using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Practice3
{
    internal class BackupFacade
    {
        private AddressBok addressBok;
        private Message message;
        private Photo photo;

        public BackupFacade() 
        {
            addressBok = new AddressBok();
            message = new Message();
            photo = new Photo();
        }

        public void BakupData() 
        {
            addressBok.GetdATA();
            message.GetData();
            photo.GetData();
            Console.WriteLine("備份資料中...");
        }
    }
}
