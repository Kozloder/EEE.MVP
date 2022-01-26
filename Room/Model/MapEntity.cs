using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class MapEntity
    {
        public readonly int ID;
        public readonly int x, y;

        public MapEntity(int ID, int x, int y)
        {
            this.ID = ID;
            this.x = x;
            this.y = y;
        }
    }
}