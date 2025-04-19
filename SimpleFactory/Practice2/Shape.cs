using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Practice2
{
    internal abstract class Shape
    {
        public abstract void Draw();

        public abstract void Erase();


        public static Shape GetShape(string args)
        {
            Shape shape = null;

            switch (args) 
            {
                case "circle":
                    shape = new Circle();
                    break;
                case "rectangle":
                    shape = new Rectangle();
                    break;
                case "triangle":
                    shape = new Triangle();
                    break;
            }

            return shape;
        }
    }
}
