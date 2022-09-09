using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POE_Part_1
{
    public class EmptyTile : Tile
    {
        public EmptyTile(int xVal, int yVal ): base(xVal, yVal)
        {
            this.x = xVal;
            this.y = yVal;
        }


    }
}
