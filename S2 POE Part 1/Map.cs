using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POE_Part_1
{
    public class Map
    {
        /*
         * A 2D Tile array to represent the map. This character array will be updated
        at all times to show the status of the map. Remember when initialising your
        map that it must be bordered with Obstacle tiles around the outside to
        prevent Character movement outside of the map
         */
        //Student s1 = new Student();

        Map hero = new Map(); //adjust
        public Map()
            {
                
            }
        //Enemy array

        public int width;
        public int height;
        public int maxMapWidth;
        public int maxMapHeight;
        public int enemies = 4;

        //A Random object for randomising numbers.

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyNum) 
            {
                this.width = minWidth;
                this.height = minHeight;
                this.maxMapWidth = maxWidth;
                this.maxMapHeight = maxHeight;
                this.enemies = enemyNum;
                
            }
        public void getmap()
        {
            
        }
        
    }
}
