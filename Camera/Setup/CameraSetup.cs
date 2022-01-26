using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;
using Installers;

namespace EEE
{
    public class CameraSetup : MySetup
    {
        private CameraModel _camera;
        private Player player;

        [Inject]
        public void Construct(CameraModel cameraModel, Player player)
        {
            this._camera = cameraModel;
            this.player = player;
        }


        public override void Setup(SetupContext ctx)
        {
            //_camera.Main.transform.parent = context.Attached;
            _camera.Main.Follow(player.transform);
        }

        public override void Dispose()
        {
            
        }
    }
}