using Bridge.Example1;
using Bridge.Example2;
using Bridge.Practice1;
using Bridge.Practice2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImplementor implementor = new ConcreteImplementor();
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.SetImpl(implementor);


            Image image = new PNGImage();
            ImageImp imp = new LinuxImp();
            image.SetImageImp(imp);
            image.ParseFile("1234");


            List<IAirPlan> plan = new List<IAirPlan>();
            plan.Add(new PassengerPlan());
            plan.Add(new CargoPlan());

            PlanMaker planMaker = new Airbus(plan);
            planMaker.GeneratePlan();


            IDataBase dataBase = new SQL();
            ConvertUtil convertUtil = new ConverToTXT(dataBase);
            convertUtil.Convert();

            Console.Read();
        }
    }
}