using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example2
{
    internal class FileReader
    {
        public string Read(string fileNameSrc) 
        {
            Console.WriteLine("讀取文件..取得明文");

            FileStream fileStream = null;

            StringBuilder sb = new StringBuilder();

            try
            {
                fileStream = new FileStream(fileNameSrc, FileMode.Open);
                int data;
                while ((data = fileStream.ReadByte()) != -1) 
                {
                    sb=sb.Append((char)data);
                }

                fileStream.Close();
                Console.WriteLine(sb.ToString());
            }
            catch (FileNotFoundException ex)
            {

            }
            catch (IOException ex) 
            {
            
            }

            return sb.ToString();
        }
    }
}
