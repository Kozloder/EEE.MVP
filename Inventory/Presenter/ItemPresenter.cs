using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class ItemPresenter : IItemPresenter
    {
        public IItemModel Model { get; }
        public IItemView View { get; }

        public ItemPresenter(IItemModel model, IItemView view)
        {
            this.Model = model;
            this.View = view;
        }
    }
}