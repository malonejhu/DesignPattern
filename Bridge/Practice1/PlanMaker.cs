using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Practice1
{
    internal abstract class PlanMaker
    {
        protected List<IAirPlan> airPlan;

        public PlanMaker(List<IAirPlan> airPlan)
        {
            this.airPlan = airPlan;
        }

        public abstract void GeneratePlan();
    }
}
