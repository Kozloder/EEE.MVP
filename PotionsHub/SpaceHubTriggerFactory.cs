using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class SpaceHubTriggerFactory : ITriggereableFactory<NoTriggerParam>
    {
        private ISpaceHub spaceHub;

        public SpaceHubTriggerFactory(ISpaceHub spaceHub)
        {
            this.spaceHub = spaceHub;
        }

        public ITriggereable<NoTriggerParam> Create() => 
            new TriggerreableAdapter<NoTriggerParam>(spaceHub);
    }
}