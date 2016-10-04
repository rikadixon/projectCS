using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_in_15
{
    class Game
    {
        public int[,]field  { get; private set; }
        Game() { }
        public Game (params int[] Values)
        {   int valuse_cout = 0;
            int size_of_values = (int)Math.Sqrt(Values.Length);
            int[,] field_user = new int[size_of_values,size_of_values];
            for (int i = 0; i < size_of_values; i++)
            {
                for (int j = 0; j < size_of_values; j++)
                {
                    field_user[i,j] = Values[valuse_cout];
                    valuse_cout++;
                }
                field = field_user;
            }
        }

        public int this [int x,int y]
        {   
            get{
                return field[x,y];
            }
       
        }
    public int[] GetLocation(int value) {
            int[] indexes = new int[2];
            for (int i = 0; i < (int)Math.Sqrt(field.Length); i++)
            {
                for (int j = 0; j < (int)Math.Sqrt(field.Length); j++)
                {
                    if (value == field[i, j])
                    {
                        indexes[0] = i;
                        indexes[1] = j;
                        break;
                    }
                }
            }
            return indexes;
        }

     public void Shift(int value)
        { int[] index_value = GetLocation(value);
          int[] index_of_0 = GetLocation(0);
          int x = index_value[0], y = index_value[1];
          int x_0 = index_of_0[0], y_0 = index_of_0[1];
            if (field[x - 1, y - 1] == field[x_0, y_0])
            {
                field[x_0, y_0] = field[x, y];
                field[x, y] = 0;
            }
            if (field[x - 1, y + 1] == field[x_0, y_0])
              {
                field[x_0, y_0] = field[x, y];
                field[x, y] = 0;
            }
            if (field[x + 1, y - 1] == field[x_0, y_0])
            {
                field[x_0, y_0] = field[x, y];
                field[x, y] = 0;
            }
            if (field[x + 1, y +1] == field[x_0, y_0])
            {
                field[x_0, y_0] = field[x, y];
                field[x, y] = 0;
            }
            else
            {
                throw new ArgumentException("Рядом нет пустых ячеек");
            }
        }

        }
    }
