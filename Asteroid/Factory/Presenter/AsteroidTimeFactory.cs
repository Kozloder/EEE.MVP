using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;
using UniRx;

namespace EEE
{
    public class AsteroidTimeFactory : MonoBehaviour
    {
        [SerializeField]
        private FactoryTimeModel<Asteroid> time;
        [SerializeField]
        private FactorySpawnPoint<Asteroid> point;
        [SerializeField]
        private FactorySpawnObject<Asteroid> asteroidPrefab;
        [SerializeField]
        private GameObject asteroidsParent;

        private AsteroidFactory factory;

        [Inject]
        public void Construct(FactoryTimeModel<Asteroid> time, 
                              FactorySpawnPoint<Asteroid> point, 
                              FactorySpawnObject<Asteroid> asteroidPrefab,
                              AsteroidFactory factory)
        {
            this.time = time;
            this.point = point;
            this.asteroidPrefab = asteroidPrefab;
            this.factory = factory;
        }

        private void Start()
        {
            Observable.Timer(TimeSpan.FromMilliseconds(time.Next()))
                      .Repeat()
                      .Subscribe(_ => 
                      {
                          var prefab = asteroidPrefab.Next();
                          var asteroid = factory.Create(prefab)
                                                .Position(point.Next())
                                                .Rotation(Quaternion.identity)
                                                .Parent(asteroidsParent);
                      }).AddTo(this);
        }
    }
}