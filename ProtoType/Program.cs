using ProtoType.Example1;
using ProtoType.Example2;
using ProtoType.Example3;
using ProtoType.Practice1;
using ProtoType.Practice2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConcreteProtoType protoType = new ConcreteProtoType();
            //protoType.Attr = "123";
            //ConcreteProtoType copy = (ConcreteProtoType)protoType.Clone();
            //copy.Attr = "456";

            //Console.WriteLine(protoType.Attr);


            //ConcreteProtoTypeA protoType = new ConcreteProtoTypeA();
            //ConcreteProtoTypeA copy = protoType.Clone();

            //Console.WriteLine(protoType == copy);
            //Console.WriteLine(protoType.Member == copy.Member);


            //ConcreteProtoTypeB protoType = new ConcreteProtoTypeB();
            //ConcreteProtoTypeB copy = (ConcreteProtoTypeB)protoType.Clone();
            //Console.WriteLine(protoType == copy);
            //Console.WriteLine(protoType.Member == copy.Member);

            //WeeklyLog log_previous = new WeeklyLog();
            //log_previous.Attachment = new Attachment();

            //log_previous.Name = "123";
            //log_previous.Attachment.Name = "AA";

            //WeeklyLog log_new = log_previous.Clone();

            //Console.WriteLine(log_new == log_previous);
            //Console.WriteLine(log_new.Attachment == log_previous.Attachment);

            //log_new.Name = "456";
            //log_new.Attachment.Name = "BB";
            //Console.WriteLine(log_previous.Attachment.Name);


            DataChart oldChart = new DataChart();
            oldChart.ID = "1";


            DataChart newChart= oldChart.Clone();
            newChart.ID = "2";

            Console.Write(oldChart.ID);

            Console.Read();
        }
    }
}