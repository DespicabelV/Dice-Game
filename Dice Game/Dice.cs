using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Game
{
    class Dice
    {
        public int Eyes;

        static Random rand = new Random();

        public void Roll()
        {
            Eyes = rand.Next(1, 7);
        }
    }
}
