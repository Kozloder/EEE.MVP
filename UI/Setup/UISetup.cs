using Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace EEE
{
    public class UISetup : MySetup
    {
        private UICanvas ui;

        [Inject]
        public void Construct(UICanvas ui)
        {
            this.ui = ui;
        }

        public override void Setup(SetupContext ctx)
        {
            //var attached = context.Attached;

            //ui.FreeFlightCanvas.Canvas.transform.SetParent(attached, true);
            //ui.QuestCanvas.Canvas.transform.SetParent(attached, true);
        }

        public override void Dispose()
        {

        }
    }
}