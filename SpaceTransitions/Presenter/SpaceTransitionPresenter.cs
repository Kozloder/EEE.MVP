using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
    public class SpaceTransitionPresenter : MonoBehaviour, ISpaceTransitionPresenter
    {
        public ISpaceTransitionModel TransitionModel { get; }

        public ISpaceTransitionView TransitionView { get; }

        
    }
}