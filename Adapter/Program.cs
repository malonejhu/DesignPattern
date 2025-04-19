using Adapter.Example1;
using Adapter.Example3;
using Adapter.Practice2;
using Adapter.Practice3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget adapter = new Example1.Adapter();
            adapter.Request();


            Example2.ITarget adapter2 = new Example2.Adapter(new Example2.Adaptee());
            adapter2.Request();

            IScoreOperation scoreOperation = new OperationAdapter();

            int[] scores = { 84, 75, 50, 69, 90, 91, 80, 96 };
            int[] result;
            int score;

            result = scoreOperation.Sort(scores);

            foreach (var item in result)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("");

            score = scoreOperation.Search(result, 90);
            if (score != -1)
            {
                Console.WriteLine("找到成績90");
            }
            else 
            {
                Console.WriteLine("沒有找到成績90");
            }


            score = scoreOperation.Search(result, 92);
            if (score != -1)
            {
                Console.WriteLine("找到成績92");
            }
            else
            {
                Console.WriteLine("沒有找到成績92");
            }


            IPlayer player = new PlayerAdapter();
            player.Play("Real");


            ICrypto crypto = new CryptoAdapter();
            crypto.Encode("456");

            Practice4.CryptorAdapter cryptorAdapter = new Practice4.CryptorAdapter();
            cryptorAdapter.Encode("123");


            Console.Read();
        }
    }
}