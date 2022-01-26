using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public interface ISpaceTransitionPresenter
    {
        ISpaceTransitionModel TransitionModel { get; }
        ISpaceTransitionView TransitionView { get; }
    }
}