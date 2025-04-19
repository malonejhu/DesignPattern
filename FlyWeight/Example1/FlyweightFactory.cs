using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Example1
{
    internal class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public Flyweight GetFlyweight(string key) 
        {
            if (flyweights.ContainsKey(key))
            {
                return(Flyweight)flyweights[key];
            }
            else 
            {
                Flyweight fs = new ConcreteFlyweight("state");
                flyweights.Add(key, fs);
                return fs;
            }
        }
    }
}
