using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;

namespace EEE
{
    public class PlayerInstaller : MonoInstaller<PlayerInstaller>
    {
        [SerializeField]
        private Player player;

        public override void InstallBindings()
        {
            Container.Bind<Player>()
                     .ToSelf()
                     .FromComponentInNewPrefab(player)
                     .AsSingle()
                     .NonLazy();
        }
    }
}