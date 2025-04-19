using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example2
{
    internal class EncryptFacade
    {
        private FileReader reader;
        private CipherMachine cipherMachine;
        private FileWriter fileWriter;

        public EncryptFacade() 
        {
            reader = new FileReader();
            cipherMachine = new CipherMachine();
            FileWriter fileWriter = new FileWriter();
        }

        public void FileEncrypt(string fileNameSrc, string fileNameDesc) 
        {
            string planStr = reader.Read(fileNameSrc);
            string encryptStr=cipherMachine.Encrypt(planStr);
            fileWriter.Write(encryptStr, fileNameDesc);
        }
    }
}