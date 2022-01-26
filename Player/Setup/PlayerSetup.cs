using Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace EEE
{
    public class PlayerSetup : MySetup
    {
        [SerializeField]
        private Transform point;
        private Player player;

        [Inject]
        public void Construct(Player player)
        {
            this.player = player;
        }

        public override void Setup(SetupContext ctx)
        {
            //player.transform.parent = context.Attached;
            player.transform.position = point.position;
            player.transform.rotation = point.rotation;

        }

        public override void Dispose()
        {
            
        }
    }
}