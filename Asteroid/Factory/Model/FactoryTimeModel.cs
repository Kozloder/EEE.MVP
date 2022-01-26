using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;

namespace EEE
{
    [Serializable]
    public class FactoryTimeModel<T>
    {
        public Func<float> Next;
    }
}