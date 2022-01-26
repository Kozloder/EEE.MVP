using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class DeliveryItemModel : IItemModel
    {
        public event Action OnInventoryAdd;
        public event Action OnInventoryRemove;

        public void InventoryAdd()
        {
            
        }

        public void InventoryRemove()
        {
            
        }
    }
}