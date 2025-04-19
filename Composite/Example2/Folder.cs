using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example2
{
    internal class Folder : AbstractFile
    {
        private List<AbstractFile> fileList = new List<AbstractFile>();
        //public string name { get; set; }

        public Folder(string name)
        {
            this.name = name;
        }

        public override void Add(AbstractFile file)
        {
            fileList.Add(file);
        }

        public override AbstractFile GetChild(int i)
        {
            return fileList[i];
        }

        public override void KillVirus()
        {
            foreach (var item in fileList) 
            {
                item.KillVirus();
            }
        }

        public override void Remove(AbstractFile file)
        {
            fileList.Remove(file);
        }

        public override void ShowName(string name)
        {
            foreach (var item in fileList)
            {
                if (name == "")
                {
                    Console.Write(this.name+"/");
                }

                
                item.ShowName(this.name + "/");
            }
        }
    }
}
