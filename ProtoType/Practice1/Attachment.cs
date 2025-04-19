using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Practice1
{
    [Serializable]
    internal class Attachment
    {
        private string name;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public void Download() 
        {
            Console.WriteLine($"下載附件，文件名為{0}", name);
        }
    }
}