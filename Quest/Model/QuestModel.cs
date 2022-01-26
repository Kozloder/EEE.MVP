using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class QuestModel : IQuestModel
    {
        public event Action OnCompleted;
        public event Action OnFailed;

        public QuestModel()
        {
            this.OnCompleted = default;
            this.OnFailed = default;
        }
    }
}