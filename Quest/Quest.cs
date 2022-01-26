using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class Quest : MonoBehaviour
    {
        [SerializeField]
        private string questName;
        [SerializeField]
        private string id;

        private IQuestView view;

        //when we destroy quest in editor
        private void OnDestroy()
        {
            view.Hide();
        }

        public static Quest Create(string id, 
                                   string name, 
                                   IQuestView view)
        {
            var quest = new GameObject($"Quest[{name}]-{id}")
                           .AddComponent<Quest>();

            quest.view = view;

            return quest;
        }
    }
}