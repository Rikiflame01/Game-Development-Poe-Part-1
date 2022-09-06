using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POE_Part_1
{
    public abstract class Tile
    {
        //Test sync 

        protected int x;
        protected int y;

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon
        }

        public int xPos
        {
            get { return x; }
            set { x = value; }
        }
        public int yPos
        {
            get { return y; }
            set { y = value; }
        }

        public TileType type
        {
            get { return type; }
            set { type = value; }
        }

        public Tile(int xVal, int yVal, TileType typeOfTile)
        {
            this.x = xVal;
            this.y = yVal;
            this.type = typeOfTile;
        }

    }
}
