using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace EEE
{
    public class DeliveryQuestFactoryInstaller : MonoInstaller<DeliveryQuestFactoryInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IQuestFactory>().To<QuestDeliveryFromSpaceHubToDestinationFactory>().AsSingle();
        }
    }
}