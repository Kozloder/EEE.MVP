using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace EEE
{
    public class HealthTextView : MonoBehaviour
    {
        [SerializeField]
        private ReactiveProperty<HealthModel> health;
        [SerializeField]
        private Text text;

        [Inject]
        public void Construct(ReactiveProperty<HealthModel> health) 
        {
            this.health = health;
        }

        private void Start()
        {
            health.SubscribeToText(text).AddTo(this);
        }
    }
}