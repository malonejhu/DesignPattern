using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Practice2
{
    internal class DataChart
    {
        public string ID { get; set; }
        public string Color { get; set; }
        public string Data { get; set; }


        public DataChart Clone() 
        {
            DataChart copy = new DataChart();
            copy.ID=this.ID;
            copy.Color = this.Color;
            copy.Data = this.Data;

            return copy;
        }
    }
}
