﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POE_Part_1
{
    public class Obstacle : Tile
    {
        public Obstacle(int xVal, int yVal) : base(xVal, yVal)
        {
            this.x = xVal;
            this.y = yVal;
            //no character can move past
        }
    }
}
