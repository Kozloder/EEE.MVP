using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class ActiveGamemodePresenter
    {
        private IGamemodePresenter active;

        public void Active(IGamemodePresenter gamemode)
        {
            if (active != null)
            {
                if (active != gamemode)
                {
                    var view = active.View;

                    view.Hide();
                }
            }

            var _view = gamemode.View;
            _view.Show();

            active = gamemode;
        }
    }
}