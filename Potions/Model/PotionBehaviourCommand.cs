using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public struct PotionBehaviourCommand
    {
        public RaycastHit2D Hit;
        public Action<RaycastHit2D> Callback;

        public float Force;
    }
}