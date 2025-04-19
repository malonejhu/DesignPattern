using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    internal class PNGImage : Image
    {
        public override void ParseFile(string filename)
        {
            Martix martix = new Martix();
            imageImp.DoPaint(martix);
            Console.WriteLine("{0} 格式為PNG", filename);
        }
    }
}
