using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIn15
{
    public class ShiftDecorator : ImmutableGame
    {
        Game myField;
        List<int> GamesHistiry = new List<int>();
        protected new Game Shift(int value)
        {
            GamesHistiry.Add(value);
            myField.Shift(value);
            return myField;
        }

    }
}
