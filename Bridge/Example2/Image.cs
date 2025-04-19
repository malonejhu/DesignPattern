using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    internal abstract class Image
    {
        protected ImageImp imageImp;

        public void SetImageImp(ImageImp imageImp) 
        {
            this.imageImp = imageImp;
        }

        public abstract void ParseFile(string filename);
    }
}
