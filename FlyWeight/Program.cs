using FlyWeight.Example2;
using FlyWeight.Practice1;
using FlyWeight.Practice2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IgoChessFactory factory = IgoChessFactory.GetInstance();

            IgoChessman black1 = factory.GetIgoChessman("b");
            IgoChessman black2 = factory.GetIgoChessman("b");
            IgoChessman black3 = factory.GetIgoChessman("b");

            IgoChessman white1 = factory.GetIgoChessman("w");
            IgoChessman white2 = factory.GetIgoChessman("w");


            black1.Display(new Coordinates(1, 2));
            black2.Display(new Coordinates(3, 4));
            black3.Display(new Coordinates(1, 3));

            white1.Display(new Coordinates(2, 5));
            white2.Display(new Coordinates(2, 4));



            DeviceFactory deviceFactory = DeviceFactory.GetInstance();
            InternetDevice hub = deviceFactory.GetDevice("hub");
            hub.Display();
            hub.Display(new Port("9090"));


            StringFactory stringFactory = StringFactory.GetInstance();
            BaseString baseString = stringFactory.GetString("CSharp");
            baseString.DisPlay(new StringConfig("green", "2"));


            Console.Read();
        }
    }
}
