using Builder.Example1;
using Builder.Example2;
using Builder.Practice1;
using Builder.Practice2;
using Builder.Practice3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
         {
            Example1.Builder builder = new ConcreteProduct();
            Director director = new Director(builder);
            Product product = director.Construct();
            Console.WriteLine(product.PartA);
            Console.WriteLine(product.PartB);
            Console.WriteLine(product.PartC);



            ActorBuilder actorBuilder = new HeroBuilder();
            ActorContol actorContol = new ActorContol(actorBuilder);
            Actor actor = actorContol.GetActor();
            Console.WriteLine(actor.Type);
            Console.WriteLine(actor.Sex);
            Console.WriteLine(actor.Face);
            Console.WriteLine(actor.Costume);
            Console.WriteLine(actor.HairStyle);


            Console.WriteLine("--------------------");



            actorBuilder = new AngelBuilder();
            actorContol = new ActorContol(actorBuilder);
            actor = actorContol.GetActor();
            Console.WriteLine(actor.Type);
            Console.WriteLine(actor.Sex);
            Console.WriteLine(actor.Face);
            Console.WriteLine(actor.Costume);
            Console.WriteLine(actor.HairStyle);


            Console.WriteLine("--------------------");



            actorBuilder = new DevioBuilder();
            actorContol = new ActorContol(actorBuilder);
            actor = actorContol.GetActor();
            Console.WriteLine(actor.Type);
            Console.WriteLine(actor.Sex);
            Console.WriteLine(actor.Face);
            Console.WriteLine(actor.Costume);
            Console.WriteLine(actor.HairStyle);


            ComputerBuilder computerBuilder = new DesktopPC();
            Computer computer = computerBuilder.CreateComputer();
            Console.WriteLine(computer.CPU);
            Console.WriteLine(computer.Memory);
            Console.WriteLine(computer.Disk);
            Console.WriteLine(computer.Screen);


            computerBuilder = new NoteBook();
            computer = computerBuilder.CreateComputer();
            Console.WriteLine(computer.CPU);
            Console.WriteLine(computer.Memory);
            Console.WriteLine(computer.Disk);
            Console.WriteLine(computer.Screen);


            computerBuilder = new Server();
            computer = computerBuilder.CreateComputer();
            Console.WriteLine(computer.CPU);
            Console.WriteLine(computer.Memory);
            Console.WriteLine(computer.Disk);
            Console.WriteLine(computer.Screen);


            UIBuilder uIBuilder = new FullUI();
            VideoPlayer videoPlayer = uIBuilder.CreateVideoPlayer();
            videoPlayer.UIFunc.ForEach(func => Console.WriteLine(func));

            Console.WriteLine("--------------------");

            uIBuilder = new MemoryUI();
            videoPlayer = uIBuilder.CreateVideoPlayer();
            videoPlayer.UIFunc.ForEach(func => Console.WriteLine(func));

            Console.WriteLine("--------------------");

            uIBuilder = new SimpleUI ();
            videoPlayer = uIBuilder.CreateVideoPlayer();
            videoPlayer.UIFunc.ForEach(func => Console.WriteLine(func));


            string oldModel = "TO97-SD2-AAX1-000";
            int series =int.Parse(oldModel.Split('-').FirstOrDefault().ToCharArray()[3].ToString());

            string NewModelForQuery = "";
            string NewModel = "";

            IModelBuilder modelBuilder;

            if ((oldModel.StartsWith("TO") == true && series >= 6) || (oldModel.StartsWith("TO") == false && series >= 4))
            {
                modelBuilder = new NewModelBuilder(oldModel, "IY0");
                NewModelForQuery = ((NewModelBuilder)modelBuilder.GenerateModelPart1().GenerateModelPart2()).GenerateModelForQuery("I", "X");

                
                ((NewModelBuilder)modelBuilder).ClearModelPart("IX_", "IY0");
                NewModel = modelBuilder.GenerateModelPart3("I", "A", "X", "1").GenerateModelPart4().GenerateModel();


                Console.WriteLine(NewModelForQuery);
                Console.WriteLine(NewModel);
            }
            else
            {
                modelBuilder = new OldModelBuilder(oldModel, "IY0");
                NewModelForQuery = ((OldModelBuilder)modelBuilder.GenerateModelPart1().GenerateModelPart2()).GenerateModelForQuery("I", "X", "A");


                ((OldModelBuilder)modelBuilder).ClearModelPart("IXA_", "IY0");
                NewModel = modelBuilder.GenerateModelPart3("I", "A", "X", "1").GenerateModelPart4().GenerateModel();


                Console.WriteLine(NewModelForQuery);
                Console.WriteLine(NewModel);
            }

            Console.Read();
        }
    }
}