using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;

namespace EEE
{
    public class SpaceHubInstaller : MonoInstaller<SpaceHubInstaller>
    {
        [SerializeField]
        private SpaceHub spaceHub;

        public override void InstallBindings()
        {
            var isPrefab = spaceHub.gameObject.scene.name == null;

            var to =  Container.Bind(typeof(SpaceHub), typeof(ISpaceHub))
                     .To<SpaceHub>();

            if (isPrefab)
                to.FromComponentInNewPrefab(spaceHub)
                  .AsSingle()
                  .NonLazy();
            else
                to.FromComponentOn(spaceHub.gameObject)
                  .AsSingle()
                  .NonLazy();
        }
    }
}