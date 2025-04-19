using Decorator.Example1;
using Decorator.Example2;
using Decorator.Practice1;
using Decorator.Practice2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            Component decorator = new ConcreteDecorator(component);
            decorator.Operation();



            VisualComponent windowComponent = new Window();
            VisualComponent scrollDecorator = new ScrollDecorator(windowComponent);
            VisualComponent borderDecorator = new BlackBorder(scrollDecorator);
            borderDecorator.Display();



            Phone simplePhone = new SimplePhone();
            Phone JarPhone=new JarPhone(simplePhone);
            Phone lightPhone = new LightPhone(JarPhone);
            lightPhone.Display();



            Beverage espresso = new Espresso();
            Beverage milkDecorator = new MilkDecorator(espresso);
            Beverage mochaDecorator = new MochaDecorator(milkDecorator);
            Console.WriteLine(mochaDecorator.GetDescription());
            Console.WriteLine(mochaDecorator.GetCost());


            Console.Read();
        }
    }
}