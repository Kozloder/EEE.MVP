using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public interface IItemPresenter
    {
        IItemView View { get; }
        IItemModel Model { get; }
    }
}