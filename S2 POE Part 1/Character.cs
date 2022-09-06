using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POE_Part_1
{
    public abstract class Character : Tile
    {
        protected Character(int xVal, int yVal, TileType typeOfTile) : base(xVal, yVal, typeOfTile)
        {
        }

        protected int hp;
        protected int maxHp;
        protected int damage;

        Tile[] gameTiles;

        public enum Movement
        {
            noMovement,
            up,
            down,
            left,
            right
        }


    }
}
