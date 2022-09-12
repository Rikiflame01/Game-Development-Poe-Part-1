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
        protected TileType _tileType;

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon
        }

        public TileType TileTypes { get { return _tileType; } set { _tileType = value; } }

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
        public Tile()
        {

        }

        public Tile(int xVal, int yVal)
        {
            this.x = xVal;
            this.y = yVal;
        }

        public Tile(int xVal, int yVal, TileType typeOfTile)
        {
            this.x = xVal;
            this.y = yVal;
            this._tileType = typeOfTile;
        }
        
    }
}
