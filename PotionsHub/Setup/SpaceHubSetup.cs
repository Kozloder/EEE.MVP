using Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;

namespace EEE
{
    public class SpaceHubSetup : MySetup
    {
        [SerializeField]
        private Transform position;

        private SpaceHub spaceHub;

        [Inject]
        public void Construct(SpaceHub spaceHub)
        {
            this.spaceHub = spaceHub;
        }


        public override void Setup(SetupContext ctx)
        {
            //spaceHub.transform.parent = context.Attached;
            spaceHub.transform.position = position.position;
            spaceHub.transform.rotation = position.rotation;
        }

        public override void Dispose()
        {
            
        }
    }
}