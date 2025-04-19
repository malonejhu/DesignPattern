using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example2
{
    internal class FileWriter
    {
        public void Write(string encryptStr, string fileNameDes) 
        {
            Console.WriteLine("保存密文");

            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(fileNameDes, FileMode.Create);
                byte[] str=Encoding.Default.GetBytes(encryptStr);
                fileStream.Write(str, 0, str.Length);
                fileStream.Flush();
                fileStream.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("本文件不存在");
            }
            catch (IOException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("文件操作錯誤");
            }


        }
    }
}
