using AbstractFactory.Example1;
using AbstractFactory.Example2;
using AbstractFactory.Practice1;
using AbstractFactory.Practice2;
using AbstractFactory.Practice3;
using AbstractFactory.Practice4;
using AbstractFactory.Practice5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example1.AbstractFactory factory = new ConcreteFactory1();
            //factory.CreateProductA();
            //factory.CreateProductB();

            //factory = new ConcreteFactory2();
            //factory.CreateProductA();
            //factory.CreateProductB();


            SkinFactory skinFactory = new SprinFactory();
            Button button = skinFactory.CreateButton();
            Text text = skinFactory.CreateText();
            Combox combox = skinFactory.CreateCombox();



            skinFactory = new SummerFactory();
            button = skinFactory.CreateButton();
            text = skinFactory.CreateText();
            combox = skinFactory.CreateCombox();


            IComponentFactory componentFactory = new PCFactory();
            ICPU CPU = componentFactory.CreateCPU();
            IRAM RAM = componentFactory.CreateRAM();

            componentFactory = new MACFactory();
            CPU = componentFactory.CreateCPU();
            RAM = componentFactory.CreateRAM();


            IFactory factory = new HaierFactory();
            ITV tv = factory.CreateTV();
            IConditioner conditioner = factory.CreateConditioner();


            factory = new TCLFactory();
            tv = factory.CreateTV();
            conditioner = factory.CreateConditioner();


            IDataBaseOperator dataBaseOperator = new OracleOperator();
            IConnection connection = dataBaseOperator.CreateConnection();
            ICommand command=dataBaseOperator.CreateCommand();


            dataBaseOperator = new MySQLOperator();
            connection = dataBaseOperator.CreateConnection();
            command = dataBaseOperator.CreateCommand();


            IOSFactory OSFactory = new WindowsFactory();
            IOSButton OSButton = OSFactory.CreateButton();
            IOSText OSText = OSFactory.CreateOSText();

            OSFactory = new LinuxFactory();
            OSButton = OSFactory.CreateButton();
            OSText = OSFactory.CreateOSText();


            IMobileFactory mobileFactory = new Android();
            IOperation operation = mobileFactory.CreateOperation();
            IUI UI = mobileFactory.CreateUI();


            mobileFactory = new IOS();
            operation = mobileFactory.CreateOperation();
            UI = mobileFactory.CreateUI();


            Console.Read();
        }
    }
}