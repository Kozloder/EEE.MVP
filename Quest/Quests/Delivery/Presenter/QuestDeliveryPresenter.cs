using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class QuestDeliveryPresenter : IQuestPresenter
    {
        private IDeliveryQuestModel model;
        public IQuestModel Model => model;

        public IQuestView View { get; }

        public QuestDeliveryPresenter(IDeliveryQuestModel model, IQuestView view)
        {
            this.model = model;
            this.View = view;
        }

        public void Dispose()
        {
            
        }
    }
}