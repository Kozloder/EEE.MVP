using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class TriggerreableAdapter<T> : ITriggereable<T>
    {
        public event Action<T> OnTrigger;

        private ITriggereable<T> triggerable;

        public TriggerreableAdapter(ITriggereable<T> triggereable)
        {
            this.triggerable = triggereable;
            this.triggerable.OnTrigger += OnTrigger;
        }

        public void Destroy()
        {
            this.triggerable.OnTrigger -= OnTrigger;
            this.triggerable = null;
            OnTrigger = null;
        }
    }
}