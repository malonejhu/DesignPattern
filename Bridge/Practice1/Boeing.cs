using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Practice1
{
    internal class Boeing : PlanMaker
    {
        public Boeing(List<IAirPlan> airPlan) : base(airPlan)
        {
        }

        public override void GeneratePlan()
        {
            Console.WriteLine("Boeing產生");
            foreach (var plan in airPlan)
            {
                plan.GenerateAirPlan();
            }
        }
    }
}
