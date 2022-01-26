using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UniRx;

namespace EEE
{
    [Serializable]
    public class FactorySpawnPoint<T>
    {
        public Func<Vector3> Next;
    }
}