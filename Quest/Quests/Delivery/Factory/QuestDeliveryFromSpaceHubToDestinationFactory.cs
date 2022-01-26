using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace EEE
{
    public class QuestDeliveryFromSpaceHubToDestinationFactory : IQuestFactory
    {
        private IQuestView questView;
        private IItemPresenter deliveryItem;

        private SpaceHubTriggerFactory spaceHubTriggerFactory;
        private ITriggereableFactory<NoTriggerParam> destinationTrigger;

        private IRewardWallet questReward;

        [Inject]
        public QuestDeliveryFromSpaceHubToDestinationFactory(IQuestView questView,
                                                             IItemPresenter deliveryItem,
                                                             SpaceHubTriggerFactory spaceHubTriggerFactory,
                                                             ITriggereableFactory<NoTriggerParam> destinationTrigger,
                                                             IRewardWallet questReward)
        {
            this.questView = questView;
            this.deliveryItem = deliveryItem;
            this.spaceHubTriggerFactory = spaceHubTriggerFactory;
            this.destinationTrigger = destinationTrigger;
            this.questReward = questReward;
        }

        public IQuestPresenter Create()
        {
            var questModel = new QuestDeliveryModel();
            var fromTrigger = this.spaceHubTriggerFactory.Create();

            questModel.OnCompleted += questReward.Reward;

            fromTrigger.OnTrigger += _ => 
            {
                var delivery = deliveryItem.Model;
                var view = deliveryItem.View;

                view.Show();
                delivery.InventoryAdd();

                var toTrigger = this.destinationTrigger.Create();

                toTrigger.OnTrigger += _ => 
                {
                    view.Hide();
                    delivery.InventoryRemove();

                    questModel.Delivered();

                    toTrigger.Destroy();
                };

                fromTrigger.Destroy();
            };

            return new QuestPresenter(questView, questModel);
        }
    }
}