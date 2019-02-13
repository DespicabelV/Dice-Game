using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Game
{
    class Player
    {
       public string name;
       public int SumEyes;
       
       public void Roll()
        {
            Dice d1 = new Dice();
            d1.Roll();

            Dice d2 = new Dice();
            d2.Roll();

            SumEyes = d1.Eyes + d2.Eyes;
        }
    }
}
