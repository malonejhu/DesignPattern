using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Practice2
{
    internal class StringConfig
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public StringConfig(string color,string size)
        {
            this.Color = color;
            this.Size = size;
        }
    }
}
