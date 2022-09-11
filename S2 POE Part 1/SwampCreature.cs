using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POE_Part_1
{
    public class SwampCreature : Enemy
    {

        /*
         Create the concrete Swamp Creature class which inherits from Enemy. It contains:
        • A constructor that receives only an X and Y position, but delegates its
        variable setting mostly to the Enemy class along the following parameters:
        o Swamp Creatures have 10 HP
        o Swamp Creatures do 1 damage
        An overridden ReturnMove() method: This method does not use the optional
        movement parameter. Instead, it randoms a direction for the Swamp Creature to
        move in and checks that movement against the Swamp Creature’s vision array. If
        something is in the way (a Hero or a Wall for now), the random position should be
        rerolled. When a valid position is chosen, it is returned from the method.
         */
        public SwampCreature(int xVal, int yVal, int damage, int hp, int maxHp, string characterSymbol, TileType typeOfTile) : base(xVal, yVal, damage, hp, maxHp, characterSymbol, typeOfTile)
        {
            x = xVal;
            y = yVal;

        }

        public SwampCreature(int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
        }
        public SwampCreature(int damage,int xVal, int yVal)
        {
            this.CharacterDamage = damage;
            x = xVal;
            y = yVal;
        }

        public SwampCreature(int Cdamage,int health, int maxHealth, int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
            this.CharacterDamage = Cdamage;
            this.hp = health;
            this.maxHp = maxHealth;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        /*
        public int swampCreatureHealth
        {
            get { return hp; }
            set { hp = 100; }
        }
        public int swampCreatureDamage
        {
            get { return damage; }
            set { damage = 1; }
        }
        */

        /*
         * An overridden ReturnMove() method: This method does not use the optional
        movement parameter. Instead, it randoms a direction for the Swamp Creature to
        move in and checks that movement against the Swamp Creature’s vision array. If
        something is in the way (a Hero or a Wall for now), the random position should be
        rerolled. When a valid position is chosen, it is returned from the method.
         */
    }
}
