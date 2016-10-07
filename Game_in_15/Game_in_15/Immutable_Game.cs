using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIn15
{
  public  class Immutable_Game: Game
    {
      public Immutable_Game(params int[] valuse):base(valuse)
        {
        }
        
       Game SwapAndCheckFields(int x, int y, int x_0, int y_0)
        {
            
            double check = Math.Abs(Math.Sqrt((x - x_0) * (x - x_0) + (y - y_0) * (y - y_0)));
            int buffValue = this.field[x, y],
                sizeOfFild= (int)Math.Sqrt(this.indexes.Length),
                cout=0;
            int[] value=new int[this.indexes.Length];
            if ((x_0 <= field.Length) && (check == 1) && (y_0 <= field.Length) && (x_0 >= 0) && (y_0 >= 0))
            { for (int i = 0; i < sizeOfFild; i++) {
                    for(int j=0;j < sizeOfFild; j++)
                    {
                        if ((x == i) && (y == j))
                        {
                            value[cout] = 0;
                        }
                        if ((x_0 == i) && (y_0 == j))
                        {
                            value[cout] = buffValue;
                        }
                        else value[cout] = this.field[i, j];
                        cout++;
                    }
                }
                Game myGame = new Game(value);
                return myGame;
            }
            else
            {
                throw new ArgumentException("Рядом нет нулей");
            }
        }
        protected new Game Shift(int value)
        {
            Point valuePoint = GetLocation(value);
            Point zeroPoint = GetLocation(0);
            return SwapAndCheckFields(valuePoint.x, valuePoint.y, zeroPoint.y, zeroPoint.y);
            ;
        }
    }
}
