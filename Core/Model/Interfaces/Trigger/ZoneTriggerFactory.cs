using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    [Serializable]
    public class ZoneTriggerFactory : ITriggereableFactory<NoTriggerParam>
    {
        [SerializeField]
        private _ZoneTrigger trigger;
        [SerializeField]
        private Transform point;
        [SerializeField]
        private float radius;

        public ITriggereable<NoTriggerParam> Create()
        {
            Type _trigger = null;

            switch (trigger)
            {
                case _ZoneTrigger.Player:
                    _trigger = typeof(Player);
                    break;
            }

            return ZoneTrigger.Create(point.position, radius, _trigger);
        }

        enum _ZoneTrigger
        {
            Player
        }
    }
}