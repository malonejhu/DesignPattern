using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example1
{
    internal class Product
    {
        private string partA;
        private string partB;
        private string partC;

        public string PartA 
        {
            get { return partA; }
            set { partA = value; }
        }

        public string PartB
        {
            get { return partB; }
            set { partB = value; }
        }

        public string PartC
        {
            get { return partC; }
            set { partC = value; }
        }
    }
}
