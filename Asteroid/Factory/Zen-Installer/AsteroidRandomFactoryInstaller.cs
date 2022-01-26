using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace EEE
{
    public class AsteroidRandomFactoryInstaller : MonoInstaller<AsteroidRandomFactoryInstaller>
    {
        [SerializeField]
        private float spawnTime;
        [SerializeField]
        private List<Transform> spawnPositions;
        [SerializeField]
        private List<Asteroid> asteroids;

        public override void InstallBindings()
        {
            InstallTime();
            InstallPositions();
            InstallPrefabs();
            InstallFactory();
        }

        private void InstallTime() 
        {
            Container.Bind<FactoryTimeModel<Asteroid>>()
                     .ToSelf()
                     .FromInstance(new FactoryTimeModel<Asteroid>() { Next = () => spawnTime })
                     .AsSingle();
        }

        private void InstallPositions() 
        {
            Container.Bind<FactorySpawnPoint<Asteroid>>()
                     .ToSelf()
                     .FromInstance(new FactorySpawnPoint<Asteroid>() { Next = () => spawnPositions.Random().position })
                     .AsSingle();
        }

        private void InstallPrefabs()
        {
            Container.Bind<FactorySpawnObject<Asteroid>>()
                     .ToSelf()
                     .FromInstance(new FactorySpawnObject<Asteroid>() { Next = asteroids.Random })
                     .AsSingle();
        }

        private void InstallFactory()
        {
            Container.Bind<AsteroidFactory>().ToSelf().AsSingle();
        }
    }
}