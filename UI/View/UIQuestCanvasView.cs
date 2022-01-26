using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class UIQuestCanvasView : IUIQuestView
    {
        public event Action OnQuestAdd;
        public event Action OnQuestRemove;

        public event Action OnShow;
        public event Action OnHide;

        public Canvas Canvas { get; }

        private Transform questCanvas;

        public UIQuestCanvasView(Canvas canvas, Transform questCanvas)
        {
            this.Canvas = canvas;
            this.questCanvas = questCanvas;
        }

        public void Hide()
        {
            if (Canvas.enabled)
            {
                Canvas.enabled = false;
                OnHide();
            }
        }

        public void Show()
        {
            if (!Canvas.enabled)
            {
                Canvas.enabled = true;
                OnShow();
            }
        }

        public void AddQuest(Transform questView)
        {
            questView.parent = questCanvas;
        }

        public void RemoveQuest(Transform questView)
        {
            if (questView.parent == questCanvas)
            {
                questView.parent = null;
            }                   
        }
    }
}