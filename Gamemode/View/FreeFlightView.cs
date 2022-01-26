using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace EEE
{
    public class FreeFlightView : IGamemodeView
    {
        public event Action OnShow;
        public event Action OnHide;

        private IUI ui;

        [Inject]
        public FreeFlightView(IUI ui)
        {
            this.ui = ui;
        }

        public void Hide()
        {
            ui.FreeFlightUI.Hide();
            OnHide();
        }

        public void Show()
        {
            ui.FreeFlightUI.Show();
            OnShow();
        }
    }
}