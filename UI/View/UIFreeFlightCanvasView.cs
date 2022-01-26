using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class UIFreeFlightCanvasView : IUIFreeFlightView
    {
        public event Action OnShow;
        public event Action OnHide;

        public Canvas Canvas { get; }

        public UIFreeFlightCanvasView(Canvas canvas)
        {
            this.Canvas = canvas;
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
    }
}