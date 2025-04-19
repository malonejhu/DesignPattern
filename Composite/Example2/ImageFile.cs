using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example2
{
    internal class ImageFile : AbstractFile
    {
        //public string name { get; set; }
        public ImageFile(string name) 
        {
            this.name = name;
        }

        public override void Add(AbstractFile file)
        {
            Console.WriteLine("不支援該方法");
        }

        public override AbstractFile GetChild(int i)
        {
            Console.WriteLine("不支援該方法");
            return null;
        }

        public override void KillVirus()
        {
            Console.WriteLine("對圖片{0}進行殺毒", name);
        }

        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("不支援該方法");
        }

        public override void ShowName(string name)
        {
            Console.WriteLine(name + this.name);
        }
    }
}
