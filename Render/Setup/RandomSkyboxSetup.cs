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
    public class RandomSkyboxSetup : MySetup
    {
        [SerializeField]
        private Material[] skybox;

        public override void Setup(SetupContext ctx)
        {
            if (skybox.Length > 0)
                RenderSettings.skybox = skybox.Random();
        }

        public override void Dispose()
        {
            
        }
    }
}