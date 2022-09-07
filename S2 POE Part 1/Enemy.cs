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
        protected Enemy(int xVal, int yVal, int damage, int hp, int maxHp, string characterSymbol, TileType typeOfTile) : base(xVal, yVal, characterSymbol, typeOfTile)
        {
            this.x = xVal;
            this.y = yVal;
            this.type = typeOfTile;
            this.damage = damage;
            this.hp = hp;
            this.maxHp = maxHp;
            symbol = characterSymbol;
        }
        /*
         * It delegates its X and Y
           position to the Character subclass via a constructor initialiser. It then sets all
           the relevant member variables.
         */

        /*
            • An overridden ToString method that, using the enemy’s class, outputs a
            string that looks as follows:
            EnemyClassName at [X, Y] (Amount DMG)
            This will be used by the Enemy subclasses.
         */

    }



}
