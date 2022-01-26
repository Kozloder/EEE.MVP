using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace EEE
{
    public class QuestDeliveryFactoryIsntaller : MonoInstaller<QuestDeliveryFactoryIsntaller>
    {
        [SerializeField]
        private ZoneTriggerFactory destination;
        [SerializeField]
        private ZoneTriggerFactory from;
        
        public override void InstallBindings()
        {
            var deliveryItemPresenter = new ItemPresenter(new DeliveryItemModel(), new NoItemView());
            var questView = new NoQuestView();

            var sub = Container.CreateSubContainer();
            
            /*
            Container.Bind<IRewardWallet>()
            Container.Bind<IQuestFactory>()
                     .To<QuestDeliveryFactory>()
                     
                     .FromInstance(new QuestDeliveryFactory(questView, deliveryItemPresenter, from, destination, ))
                     .AsSingle();*/
        }
    }
}