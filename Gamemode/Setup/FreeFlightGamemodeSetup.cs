using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;
using Installers;

namespace EEE
{
    public class FreeFlightGamemodeSetup : MySetup
    {
        private ActiveGamemodePresenter activeGamemode;
        private IGamemodePresenter freeFlightGamemode;

        [Inject]
        public void Construct([InjectOptional(Id = GamemodeType.FreeFlight)] IGamemodePresenter freeFlightGamemode,
                              ActiveGamemodePresenter activeGamemode)
        {
            this.freeFlightGamemode = freeFlightGamemode;
            this.activeGamemode = activeGamemode;
        }

        public override void Setup(SetupContext ctx)
        {
            activeGamemode.Active(freeFlightGamemode);
        }

        public override void Dispose()
        {
            
        }
    }
}