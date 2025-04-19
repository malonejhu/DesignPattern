using Facade.Example1;
using Facade.Example2;
using Facade.Practice1;
using Facade.Practice2;
using Facade.Practice3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example1.Facade facade = new Example1.Facade();
            facade.Method();

            //EncryptFacade encryptFacade = new EncryptFacade();
            //encryptFacade.FileEncrypt("src.txt", "des.txt");


            BackupFacade backupFacade = new BackupFacade();
            backupFacade.BakupData();


            RunFacade runFacade = new RunFacade();
            runFacade.ExecuteOS();

            AbstractFacade abstractFacade = new ShowDataFacade2();
            abstractFacade.Show();

            Console.Read();
        }
    }
}
