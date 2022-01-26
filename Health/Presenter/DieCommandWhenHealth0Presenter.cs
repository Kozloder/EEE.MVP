using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UniRx;
using UnityEngine;

namespace EEE
{
    public class DieCommandWhenHealth0Presenter : MonoBehaviour
    {
        [SerializeField]
        private HealthModel health;
        [SerializeField]
        private ReactiveCommand<DieCommand> dieCommand;

        [Inject]
        public void Construct(HealthModel health, ReactiveCommand<DieCommand> dieCommand)
        {
            this.health = health;
            this.dieCommand = dieCommand;
        }

        private void Start()
        {
            health.health.ObserveEveryValueChanged(_ => _)
                         .Where(health => health.Value <= 0)
                         .Subscribe(_ => dieCommand.Execute(new DieCommand()))
                         .AddTo(this);
        }
    }
}