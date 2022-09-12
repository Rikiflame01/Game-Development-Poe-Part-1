using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace S2_POE_Part_1
{
    public class Hero : Character
    {

        public Hero(int xVal, int yVal, string characterSymbol, TileType typeOfTile) : base(xVal, yVal, characterSymbol, typeOfTile)
        {
            x = xVal;
            y = yVal;

        }
        
        public Hero(int xVal, int yVal, int health, int maxHealth)
        {
            x = xVal;
            y = yVal;
            this.hp = health;
            this.maxHp = maxHealth;


        }
        public Hero(int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
            this.hp = 20;
            this.maxHp = 20;
            this.damage = 2;

        }
        /*
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
        */

        //Remember hero damage = 2!

        /*
         * • An overridden ReturnMove() method: This method receives a movement
        indicator based on a directional button press (either on the Windows Form
        or via the keyboard). It then checks that potential movement
        (up/down/left/right) against the vision array and returns that same number
        if it is valid. If it is not valid, it returns a MovementEnum.None, which signals
        to the calling method that a movement should not be made.
         */
        

        public override string ToString()
        {
            return "Player stats: " + Environment.NewLine + "Damage:" + damage + Environment.NewLine + "Health: " + hp + " /" + maxHp+ Environment.NewLine+"["+xPos+","+yPos+"]".ToString();

        }


        //TextBox textbox = new TextBox();

        //public string returnMessage() { return "HI"; }
    }
}
