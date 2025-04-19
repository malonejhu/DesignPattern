using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Practice2
{
    internal abstract class ConvertUtil
    {
        protected IDataBase dataBase;

        public ConvertUtil(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        public abstract void Convert();
    }
}
