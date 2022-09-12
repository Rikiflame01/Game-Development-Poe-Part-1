using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POE_Part_1
{
    

    public abstract class Character : Tile
    {
        public string symbol;

        public Character(int xVal, int yVal,string characterSymbol, TileType typeOfTile) : base(xVal, yVal, typeOfTile)
        {
            //A constructor that receives X and Y positions and a symbol and delegates the
            //setting of those variables to the Tile class via a constructor initialiser.????
            x = xVal;
            y = yVal;
            symbol = characterSymbol;
            _tileType = typeOfTile;
        }
        public Character()
        {

        }

        public Character(int xVal, int yVal, string characterSymbol)
        {
            x = xVal;
            y = yVal;
            symbol=characterSymbol;
        }

        public Character(int xVal, int yVal, int health, int maxHealth)
        {
            x = xVal;
            y = yVal;
            this.hp = health;
            this.maxHp = maxHealth;
        }

        protected int range;
        protected int hp;
        protected int maxHp;
        protected int damage;

        public int health
        {
            get { return hp; }
            set { hp = value; }
        }

        public int maxHealth
        {
            get { return maxHp; }
            set { maxHp = value; }
        }
        protected int CharacterDamage
        {
            get { return damage; }
            set { damage = value; }
        }

        Tile[] gameTiles;

        public enum Movement
        {
            noMovement,
            up,
            down,
            left,
            right
        }
        
        public bool alive = true;
        public bool isInRange = false;

        public virtual void Attack(Character entity)
        {
            /*
            Public virtual void Attack(Character target): Attacks a target and decreases
            its health by the attacking character’s damage. This is declared as virtual for
            later overriding by specific enemy types.
            */
            entity.health = health-this.CharacterDamage;



        }
        public bool IsDead()
        {
            if (alive == false) { return true; }
            return false;
        }



        public virtual bool CheckRange()
        {
            if (isInRange == true) { return true; }
            return false;

           /*Public virtual bool CheckRange(Character target): Checks if a target is in
           range of a character(barehanded range is always 1, but this will be extended
           with weapon types later). It determines distance via the DistanceTo()
           method and returns true or false.
         */
        }

        /*


        /* private int DistanceTo()
         {
            Private int DistanceTo(target) – used by CheckRange(): Determines the
            absolute distance (number of spaces needed to move – e.g., diagonal is one
            up + one across = 2) between a character and its target. 
         }*/

        /*public void Move(Movement move)
        {
        Public void Move(MovementEnum move): Edits a unit’s X and Y values to
        move it up/down/left/right based on the identifier from the enum.
        }
        */


        /*public abstract Movement ReturnMove(Movement move = 0)
        {
        Public abstract MovementEnum ReturnMove(MovementEnum move = 0) –
        this will be defined by the Character subclasses. The method returns a
        direction of movement based on how the character should move, based on
        the validity of that move against a Character’s vision array.
        }
        */
        public abstract override string ToString();


    }


}
