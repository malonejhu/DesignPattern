using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Practice1
{
    internal class McDonnell : PlanMaker
    {
        public McDonnell(List<IAirPlan> airPlan) : base(airPlan)
        {
        }

        public override void GeneratePlan()
        {
            Console.WriteLine("McDonnell產生");
            foreach (var plan in airPlan)
            {
                plan.GenerateAirPlan();
            }
        }
    }
}
