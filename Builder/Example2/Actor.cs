using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    internal class Actor
    {
        private string type;
        private string sex;
        private string face;
        private string costume;
        private string hairStyle;


        public string Type 
        {
            get { return type; }
            set { type = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Face
        {
            get { return face; }
            set { face = value; }
        }

        public string Costume
        {
            get { return costume; }
            set { costume = value; }
        }

        public string HairStyle
        {
            get { return hairStyle; }
            set { hairStyle = value; }
        }
    }
}