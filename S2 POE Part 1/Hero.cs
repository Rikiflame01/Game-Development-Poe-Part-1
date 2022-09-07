using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POE_Part_1
{
    public class Hero : Character
    {
        public Hero(int xVal, int yVal, string characterSymbol, TileType typeOfTile) : base(xVal, yVal, characterSymbol, typeOfTile)
        {
            x = xVal;
            y = yVal;

        }

        public int heroHealth
        {
            get { return hp; }
            set { hp = 20; }
        }
        public int heroDamage
        {
            get { return damage; }
            set { damage = 2; }
        }
    }
}
