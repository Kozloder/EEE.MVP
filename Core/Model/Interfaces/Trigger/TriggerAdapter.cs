using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class TriggerAdapter : MonoBehaviour
    {
        public event Action<Collider> OnTrigger;

        private void OnTriggerEnter(Collider other)
        {
            OnTrigger?.Invoke(other);
        }
    }
}