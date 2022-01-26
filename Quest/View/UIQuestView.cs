using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

namespace EEE
{
    public class UIQuestView : MonoBehaviour, IQuestView
    {
        [SerializeField]
        private TextMeshPro _name;
        [SerializeField]
        private TextMeshPro description;
        [SerializeField]
        private TextMeshPro reward;
        [SerializeField]
        private Image image;
        [SerializeField]
        private Button clickButton;

        public event Action OnShow;
        public event Action OnHide;

        private Transform ui;

        public void Hide()
        {
            if (enabled)
            {
                transform.SetParent(null, true);
                enabled = false;
                OnHide();
            }
        }

        public void Show()
        {
            if (!enabled)
            {
                transform.SetParent(ui, true);
                enabled = true;
                OnShow();
            }
        }

        public static UIQuestView Create(Transform ui, 
                                         string name,
                                         string description,
                                         string reward,
                                         Sprite image,
                                         UnityAction onClick)
        {
            var questView = new GameObject($"Quest[{name}]")
                           .AddComponent<UIQuestView>()
                           .Parent(ui.gameObject);

            questView.ui = ui;
            questView._name.text = name;
            questView.description.text = description;
            questView.reward.text = reward;
            questView.image.sprite = image;
            questView.clickButton.onClick.AddListener(onClick);

            return questView;
        }
    }
}