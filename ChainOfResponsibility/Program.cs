using ChainOfResponsibility.Exampl1;
using ChainOfResponsibility.Example2;
using ChainOfResponsibility.Practice1;
using ChainOfResponsibility.Practice2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Handler handler1 = new ConcreteHandler();
            //Handler handler2 = new ConcreteHandler();
            //Handler handler3 = new ConcreteHandler();

            //handler1.SetSuccessor(handler2);
            //handler2.SetSuccessor(handler3);
            //handler1.HandleRequest("");


            //Approver wjzhang = new Director("張無忌");
            //Approver gyang = new VicePresident("楊過");
            //Approver jguo = new President("郭靖");
            //Approver meeting = new Congress("董事會");
            //Approver rhuang = new Manager("黃蓉");


            //wjzhang.SetSuccessor(rhuang);
            //rhuang.SetSuccessor(gyang);
            //gyang.SetSuccessor(jguo);
            //jguo.SetSuccessor(meeting);


            //PurchaseRequest pr1 = new PurchaseRequest(45000, 10001, "購買倚天劍");
            //PurchaseRequest pr2 = new PurchaseRequest(60000, 10002, "購買葵花寶典");
            //PurchaseRequest pr3 = new PurchaseRequest(160000, 10002, "購金剛經");
            //PurchaseRequest pr4 = new PurchaseRequest(800000, 10003, "購買桃花島");



            //wjzhang.ProcessRequest(pr1);
            //wjzhang.ProcessRequest(pr2);
            //wjzhang.ProcessRequest(pr3);
            //wjzhang.ProcessRequest(pr4);


            //Officer banZhang = new BanZhang("班長");
            //Officer paiZhang = new PaiZhang("排長");
            //Officer yinZhang = new YinZhang("營長");
            //Officer meeting = new Meeting("會議");


            //banZhang.SetSuccessor(paiZhang);
            //paiZhang.SetSuccessor(yinZhang);
            //yinZhang.SetSuccessor(meeting);

            //int enemy1 = 5, enemy2 = 11, enemy3 = 50, enemy4 = 250;


            //banZhang.SendMessage(enemy1);
            //banZhang.SendMessage(enemy2);
            //banZhang.SendMessage(enemy3);
            //banZhang.SendMessage(enemy4);

            Boss president = new Practice2.President("總經理", null);
            Boss manager = new Practice2.Manager("經理", president);
            Boss director = new Practice2.Director("主任", manager);

            int leaveDays1 = 2, leaveDays2 = 6, leaveDays3 = 11, leaveDays4 = 31;

            director.SignForm(leaveDays1);
            director.SignForm(leaveDays2);
            director.SignForm(leaveDays3);
            director.SignForm(leaveDays4);


            Console.Read();
        }
    }
}