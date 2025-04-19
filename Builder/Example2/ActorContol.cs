using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    internal class ActorContol
    {
        private ActorBuilder actorBuilder;

        public ActorContol(ActorBuilder actorBuilder)
        {
            this.actorBuilder = actorBuilder;
        }


        public Actor GetActor() 
        {
            actorBuilder.BuildType();
            actorBuilder.BuildSex();
            actorBuilder.BuildFace();
            actorBuilder.BuildHairStyle();
            actorBuilder.BuildCostume();

            return actorBuilder.CreateActor();
        }
    }
}
