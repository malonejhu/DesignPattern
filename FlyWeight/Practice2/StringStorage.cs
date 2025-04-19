using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Practice2
{
    internal class StringStorage:BaseString
    {
        public StringStorage(string text) 
        {
            this.text = text;
        }
        private string text;
        public string Text 
        {
            get { return text; }
        }

        public override void DisPlay(StringConfig config)
        {
            Console.WriteLine("顏色{0},大小{1}", config.Color, config.Size);
        }
    }
}
