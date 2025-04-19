using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    internal class JPGImage : Image
    {
        public override void ParseFile(string filename)
        {
            Martix x = new Martix();
            imageImp.DoPaint(x);
            Console.WriteLine("{0} 格式JPG", filename);
        }
    }
}
