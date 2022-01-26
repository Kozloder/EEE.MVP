using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;
using UniRx;
using UniRx.Triggers;

namespace EEE
{
    public class AsteroidOnceTriggerFactory : MonoBehaviour
    {
        [SerializeField]
        private Collider _collider;
        [SerializeField]
        private FactorySpawnPoint<Asteroid> point;
        [SerializeField]
        private FactorySpawnObject<Asteroid> asteroidPrefab;
        [SerializeField]
        private GameObject asteroidsParent;

        private AsteroidFactory factory;

        [Inject]
        public void Construct(FactorySpawnPoint<Asteroid> point,
                              FactorySpawnObject<Asteroid> asteroidPrefab,
                              AsteroidFactory factory)
        {
            this.point = point;
            this.asteroidPrefab = asteroidPrefab;
            this.factory = factory;
        }

        private void Start()
        {
            _collider.OnTriggerEnterAsObservable()
                     .First()
                     .Where(collider => collider.TryGetComponent<Ship>(out var _))
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