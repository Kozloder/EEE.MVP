using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class QuestDeliveryModel : IDeliveryQuestModel
    {
        public event Action OnCompleted;
        public event Action OnFailed;

        public QuestDeliveryModel()
        {
            
        }

        public void Delivered() => OnCompleted();
    }
}