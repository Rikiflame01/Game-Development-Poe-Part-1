using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POE_Part_1
{
    public class GameEngine
    {
        private string map;

        public string Map
        {
            get { return map; }
        }

        public GameEngine()
        {

        }

        public bool MovePlayer(int x, int y)
        {
            if (x == 250 && y == 75)
            {
                return true;
            }
            return false;
        }

    }
}
