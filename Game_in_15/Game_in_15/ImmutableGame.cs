using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIn15
{
  public  class ImmutableGame: Game
    {
      public ImmutableGame(params int[] valuse):base(valuse)
        {
        }

        Game SwapAndCheckFields(int value)
        {
            Game myGame = new Game();
            myGame = this;
            myGame.Shift(value);
                  return myGame; 
            
        
        }
        protected new Game Shift(int value)
        {
            return SwapAndCheckFields(value);
            ;
        }
    }
}
