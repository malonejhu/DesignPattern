using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    internal class DevioBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "黑衣";
        }

        public override void BuildFace()
        {
            actor.Face = "醜陋";
        }

        public override void BuildHairStyle()
        {
            actor.HairStyle = "光頭";
        }

        public override void BuildSex()
        {
            actor.Sex = "男";
        }

        public override void BuildType()
        {
            actor.Type = "惡魔";
        }
    }
}
