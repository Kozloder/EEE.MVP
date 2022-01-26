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
    public class ExplosionPotion : MonoBehaviour, IPotionBehaviourModel
    {

        public PotionBehaviourCommand Action(PotionBehaviourCommand command)
        {
            //Physics2D.OverlapCircleNonAlloc();
            //command.

            return default;
        }
    }
}