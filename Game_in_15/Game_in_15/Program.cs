using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIn15
{
    class Program
    {
        static void Main(string[] args)
        { try
            {   
                Game Fild = new Game(0, 7, 8, 1, 2, 3, 4, 5, 6);
                //Console.WriteLine(Fild.field[0, 1]);
                //Console.WriteLine(Fild[0, 1]);
                Game.Point value =Fild.GetLocation(4);
                Console.WriteLine(value.x + " " + value.y);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(Fild[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Новая");
                Fild.Shift(1);
               
                for (int i = 0; i < 3; i++)
                {
                    for (int j= 0; j< 3; j++)
                    {
                        Console.Write(Fild[i, j]+" ");
                    }
                    Console.WriteLine();
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey(true);
        }
    }
}
