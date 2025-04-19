using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Example2
{
    internal class IgoChessFactory
    {
        private static IgoChessFactory instance = new IgoChessFactory();
        private Hashtable ht;

        private IgoChessFactory() 
        {
            ht= new Hashtable();
            IgoChessman black = new BlackIgoChessman();
            IgoChessman white = new WhiteChessman();
            ht.Add("b", black);
            ht.Add("w", white);
        }


        public static IgoChessFactory GetInstance() 
        {
            return instance;
        }


        public IgoChessman GetIgoChessman(string color) 
        {
            return (IgoChessman)ht[color];
        }
    }
}
