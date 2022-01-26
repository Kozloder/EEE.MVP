using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public interface ITriggereable<T> : IDestroyable
    {
        public event Action<T> OnTrigger;
    }
}