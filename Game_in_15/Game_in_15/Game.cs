using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIn15
{
    public class Game
    {
      public struct Point
        {
            public int x;
            public int y;
	       public Point(int X, int Y) 
            {
                x = X;
                y = Y;
            }
        };
        public int[,] field { get; private set; }

        public Point[] indexes { get; private set; }

        public Game(params int[] values)
        {
            indexes = new Point[values.Length];
            int valuesLengthForCheck = values.Length - 1;
            int MaxNumber = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > MaxNumber)
                {
                    MaxNumber = values[i];
                }
            }
          if(MaxNumber== valuesLengthForCheck) { 
                int valuseCout = 0,
                    valuseSize = (int)Math.Sqrt(values.Length);
                int[,] fieldFromUser = new int[valuseSize, valuseSize];
            //if (MaxNumber== valuesLengthForCheck) {
                for (int i = 0; i < valuseSize; i++)
                {
                    for (int j = 0; j < valuseSize; j++)
                    {
                        fieldFromUser[i, j] = values[valuseCout];
                        indexes[values[valuseCout]].x = i;
                        indexes[values[valuseCout]].y = j;
                        valuseCout++;
                    }
                }
                field = fieldFromUser; }
            // indexes = buff;
            ////}
            else
            {
                    throw new ArgumentException("Не правильно введены данные ");
                }
            }

        public int this[int x, int y]
        {
            get
            {
                return field[x, y];
            }
        }

        public Point GetLocation(int value)
        {
            return indexes[value];
        }
         void SwapZeroAndValue(int x, int y, int x_0, int y_0)
        {

            field[x_0, y_0] = field[x, y];
            field[x, y] = 0;
        }

        protected void CheckFields(int x, int y, int x_0, int y_0)
        { double check = Math.Abs(Math.Sqrt((x - x_0)* (x - x_0) + (y - y_0)* (y - y_0)));

            if((x_0<=field.Length)&&(check == 1)&&(y_0 <= field.Length)&&(x_0>=0)&&(y_0>=0))
            {
                SwapZeroAndValue(x, y, x_0, y_0);
            }
            else
            {
                throw new ArgumentException("Рядом нет нулей");
            }
        }

        public Game Shift(int value)
        {
            Point valuePoint = GetLocation(value);
            Point zeroPoint = GetLocation(0);
            CheckFields(valuePoint.x, valuePoint.y, zeroPoint.y, zeroPoint.y);
            return this;
           
        }
    }
}

