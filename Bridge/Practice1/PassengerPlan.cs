using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Practice1
{
    internal class PassengerPlan : IAirPlan
    {
        public void GenerateAirPlan()
        {
            Console.WriteLine("PassengerPlan");
        }
    }
}
