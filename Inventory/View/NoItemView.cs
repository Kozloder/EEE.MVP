using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class NoItemView : IItemView
    {
        public event Action OnShow;
        public event Action OnHide;

        public void Hide()
        {
            OnHide?.Invoke();
        }

        public void Show()
        {
            OnShow?.Invoke();
        }
    }
}