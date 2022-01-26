using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UniRx;
using UnityEngine;

namespace EEE
{
    public class InputStreamIsntaller : MonoInstaller<InputStreamIsntaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<InputModel>().ToSelf().AsSingle();
        }
    }
}