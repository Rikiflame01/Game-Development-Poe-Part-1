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
        public int maxHealth
        {
            get { return maxHp; }
            set { maxHp = 20; }
        }

        public int heroDamage
        {
            get { return damage; }
            set { damage = 2; }
        }

        /*
         * • An overridden ReturnMove() method: This method receives a movement
        indicator based on a directional button press (either on the Windows Form
        or via the keyboard). It then checks that potential movement
        (up/down/left/right) against the vision array and returns that same number
        if it is valid. If it is not valid, it returns a MovementEnum.None, which signals
        to the calling method that a movement should not be made.
         */

        /*
         * An overridden ToString() method: This returns the formatted Player Stats as
        shown below:
        Player Stats:
        HP: HP/Max HP
        Damage: 2
        [X,Y]
         */

        
    }
}
