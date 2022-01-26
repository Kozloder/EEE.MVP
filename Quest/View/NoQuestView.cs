using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class NoQuestView : IQuestView
    {
        public event Action OnShow;
        public event Action OnHide;

        private bool isShown = false;

        public void Hide()
        {
            if (isShown)
            {
                OnHide();
                isShown = false;
            }
        }

        public void Show()
        { 
            if (!isShown)
            {
                OnShow();
                isShown = true;
            }
        }
    }
}