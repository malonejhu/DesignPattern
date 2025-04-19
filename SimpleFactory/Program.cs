using SimpleFactory.Example1;
using SimpleFactory.Example2;
using SimpleFactory.Practice1;
using SimpleFactory.Practice2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = Factory.GetProduct("B");
            product.MethodDiff();
            product.MethodSame();



            Chart chart = Chart.GetChart("histogram");
            chart.Display();

            chart = Chart.GetChart("linechart");
            chart.Display();

            chart = Chart.GetChart("piechart");
            chart.Display();



            Person person = PersonFactory.GetPerson("M");
            person.Say();

            person = PersonFactory.GetPerson("W");
            person.Say();

            person = PersonFactory.GetPerson("R");
            person.Say();



            Shape shape = Shape.GetShape("circle");
            shape.Draw();
            shape.Erase();


            shape = Shape.GetShape("rectangle");
            shape.Draw();
            shape.Erase();


            shape = Shape.GetShape("triangle");
            shape.Draw();
            shape.Erase();

            Console.Read();
        }
    }
}