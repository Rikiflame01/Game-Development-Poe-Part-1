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

        Tile[,] map;

        //Student s1 = new Student();
        

        
        public Map()
            {
                
            }
        //Enemy array
        private Hero hero;
        private Enemy[] enemy;
        private SwampCreature swampCreature;

        private int width;
        private int height;
        private int maxMapWidth;
        private int maxMapHeight;
        private Random randomObj;

        //A Random object for randomising numbers.
        Random randomObject = new Random();

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyNum) 
            {
                this.width = minWidth;
                this.height = minHeight;
                this.maxMapWidth = maxWidth;
                this.maxMapHeight = maxHeight;
                randomObj = new Random();
                height = randomObj.Next(minWidth, maxWidth);
                width = randomObj.Next(minHeight, maxHeight);
                
                map = new Tile[width, height];
                enemy = new Enemy[enemyNum];

            Create(Tile.TileType.Hero);

           /* for (int i = 0; i < enemyNum; i++)
            {
                enemy[i] = {SwampCreature} Create[Tile.TileType.Enemy];
            }
           */
                UpdateVision();
            }

        public Tile[,] fetchMap()
        {
            return map;
        }
        
        public void UpdateVision()
        {

        }

        public static void Create(Tile.TileType Hero)
        {
           
        }
        public Enemy[] fetchEnemies()
        {
            return enemy;
        }

        public Hero fetchHero()
        {
            return hero;
            
        }

        public int fetchWidth()
        {
            return width;
        }
        public int fetchHeight()
        {
            return height;
        }

    }
}
