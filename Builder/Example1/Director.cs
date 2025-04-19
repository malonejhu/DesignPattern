using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example1
{
    internal class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void SetBuilder(Builder builder) 
        {
            this.builder = builder;
        }

        public Product Construct() 
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();

            return builder.GetResult();
        }
    }
}
