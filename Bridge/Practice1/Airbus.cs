using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Practice1
{
    internal class Airbus : PlanMaker
    {
        public Airbus(List<IAirPlan> airPlan) : base(airPlan)
        {
        }

        public override void GeneratePlan()
        {
            Console.WriteLine("AirBus產生");
            foreach (var plan in airPlan) 
            {
                plan.GenerateAirPlan();
            }
        }
    }
}
