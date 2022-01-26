using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public interface IView
    {
        event Action OnShow;
        event Action OnHide;

        void Show();
        void Hide();
    }
}