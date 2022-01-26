using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class FactorySpawnObject<T>
    {
        public Func<T> Next;
    }
}