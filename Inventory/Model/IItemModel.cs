using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public interface IItemModel
    {
        event Action OnInventoryAdd;
        event Action OnInventoryRemove;

        void InventoryAdd();
        void InventoryRemove();
    }
}