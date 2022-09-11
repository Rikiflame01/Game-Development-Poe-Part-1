using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace S2_POE_Part_1
{
    public abstract class Enemy : Character
    {
        public Enemy(int xVal, int yVal, int damage, int hp, int maxHp, string characterSymbol, TileType typeOfTile) : base(xVal, yVal, characterSymbol, typeOfTile)
        {
            this.x = xVal;
            this.y = yVal;
            this._tileType = typeOfTile;
            this.damage = damage;
            this.hp = hp;
            this.maxHp = maxHp;
            symbol = characterSymbol;

            //random object used for randomizing numbers
        }

        public Enemy(){

        }

        public Enemy(int health, int maxHealth, int damage, int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
            this.damage = damage;
            this.hp = health;
            this.maxHp = maxHealth;
        }
        public Enemy(int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
        }
        public Enemy(int damage,int xVal, int yVal)
        {
            this.damage = damage;
            x = xVal;
            y = yVal;
        }
        /*
         * It delegates its X and Y
           position to the Character subclass via a constructor initialiser. It then sets all
           the relevant member variables.
         */

        /*public override string ToString()
        {
            return "Swamp Creature at" + "[" + xPos + "," + yPos + "]" +"(" +damage+")".ToString();

        }
        */
    }



}
