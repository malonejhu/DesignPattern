using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    internal class HeroBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "盔甲";
        }

        public override void BuildFace()
        {
            actor.Face = "英俊";
        }

        public override void BuildHairStyle()
        {
            actor.HairStyle = "飄逸";
        }

        public override void BuildSex()
        {
            actor.Sex = "男";
        }

        public override void BuildType()
        {
            actor.Type = "英雄";
        }
    }
}
