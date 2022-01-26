using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class SpaceHub : MonoBehaviour, ISpaceHub
    {
        [SerializeField]
        private TriggerAdapter triggerZone;

        public Vector3 Position { get => transform.position; set => transform.position = value; }

        public event Action<NoTriggerParam> OnTrigger;

        private void Start()
        {
            triggerZone.OnTrigger += _OnTrigger;
        }

        private void OnDestroy()
        {
            triggerZone.OnTrigger -= _OnTrigger;
        }

        public void Destroy()
        {
            Destroy(gameObject);
        }

        private void _OnTrigger(Collider other)
        {
            if (other.TryGetComponent<Player>(out var _))
            {
                OnTrigger?.Invoke(new NoTriggerParam());
            }
        }
    }
}