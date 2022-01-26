using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;

namespace EEE
{
    public class QuestPresenter : IQuestPresenter
    {
        public IQuestModel Model { get; private set; }
        public IQuestView View { get; private set; }

        public QuestPresenter(IQuestView view, IQuestModel model)
        {
            this.Model = model;
            this.View = view;
        }

        public void Dispose() { }
    }
}