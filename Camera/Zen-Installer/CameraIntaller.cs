using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine;

namespace EEE
{
    public class CameraIntaller : MonoInstaller<CameraIntaller>
    {
        [SerializeField]
        private FollowCamera cameraPrefab;

        public override void InstallBindings()
        {
            Container.Bind<CameraModel>().ToSelf().FromMethod(ctx => 
            {
                var camera = ctx.Container.InstantiatePrefab(cameraPrefab)
                                          .GetComponent<FollowCamera>();

                return new CameraModel(camera);
            }).AsSingle().NonLazy();
        }
    }
}