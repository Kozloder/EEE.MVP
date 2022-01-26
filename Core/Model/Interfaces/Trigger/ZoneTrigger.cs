using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class ZoneTrigger : MonoBehaviour, ITriggereable<NoTriggerParam>
    {
        public event Action<NoTriggerParam> OnTrigger;

        private Type trigger;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(trigger, out var _))
                OnTrigger?.Invoke(new NoTriggerParam());
        }

        public void Destroy()
        {
            OnTrigger = null;
            Destroy(this);
        }

        public static ZoneTrigger Create<Trigger>(Vector3 position, float radius)
        {
            var trigger = typeof(Trigger);

            return Create(position, radius, trigger);
        }

        public static ZoneTrigger Create(Vector3 position, float radius, Type trigger)
        {
            var go = new GameObject($"[Trigger-{trigger.Name}]");
            var shereCollider = go.AddComponent<SphereCollider>();
            var zoneTrigger = go.AddComponent<ZoneTrigger>();

            go.transform.position = position;
            shereCollider.radius = radius;
            shereCollider.isTrigger = true;

            zoneTrigger.trigger = trigger;

            return zoneTrigger;
        }
    }
}
