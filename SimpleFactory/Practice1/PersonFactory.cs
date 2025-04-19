using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Practice1
{
    internal class PersonFactory
    {
        public static Person GetPerson(string args) 
        {
            Person person = null;

            switch (args) 
            {
                case "M":
                    person = new Men();
                    break;
                case "W":
                    person = new Woman();
                    break;
                case "R":
                    person = new Robot();
                    break;
            }

            return person;
        }
    }
}
