using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UniRx;

namespace EEE
{
    [Serializable]
    public class HealthModel
    {
        [SerializeField]
        public FloatReactiveProperty health;

        public HealthModel(FloatReactiveProperty health)
        {
            this.health = health;
        }
    }
}