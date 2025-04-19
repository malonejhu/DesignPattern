using FactoryMethod.Example1;
using FactoryMethod.Example2;
using FactoryMethod.Practice2;
using FactoryMethod.Practice1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Practice3;
using FactoryMethod.Practice4;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new ConcreteFactory();
            Product product = factory.GetProduct();
            product.Show();



            LoggerFactory loggerFactory = new FileLoggerFactory();
            Logger logger = loggerFactory.CreateLogger();
            logger.WriteLog();

            loggerFactory = new DataBaseLoggerFactory();
            logger = loggerFactory.CreateLogger();
            logger.WriteLog();





            ICarFactory carFactory = new BMWFactory();
            ICar car= carFactory.GetCar();
            car.Show();

            carFactory = new BenzFactory();
            car = carFactory.GetCar();
            car.Show();





            IChartFactory chartFactory = new BarChartFactory();
            IChart chart=chartFactory.GetChart();
            chart.Show();

            chartFactory = new GraphFactory();
            chart = chartFactory.GetChart();
            chart.Show();





            IConvertFactory convertFactory = new Excel4XMLFactory();
            string source = @"C:\Users\Administrator\Desktop\PayEasy會員中心.pdf";
            IConvertToXML convetObject = convertFactory.GetConvertObject(source);
            convetObject.ConvertToXML();

            convertFactory = new DB4XMLFactory();
            source = @"102.168.2.3";
            convetObject = convertFactory.GetConvertObject(source);
            convetObject.ConvertToXML();

            convertFactory = new TXT4XMLFactory();
            source = @"C:\Users\Administrator\Desktop\PayEasy會員中心.pdf";
            convetObject = convertFactory.GetConvertObject(source);
            convetObject.ConvertToXML();





            IPICFactory PICFactory = new JPGFactory();
            IImageReader imageReader = PICFactory.GetPICReader();
            imageReader.Show();

            PICFactory = new GIFFactory();
            imageReader = PICFactory.GetPICReader();
            imageReader.Show();


            Console.Read();
        }
    }
}