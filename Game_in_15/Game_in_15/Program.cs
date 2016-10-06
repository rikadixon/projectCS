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
                Game Fild = new Game(1, 2, 3, 5, 4, 0,6,7,8);
                Console.WriteLine(Fild.field[0, 1]);
                Console.WriteLine(Fild[0, 1]);
                Game.Point value =Fild.GetLocation(6);
               Console.WriteLine(value.x + " " + value.y);
                Fild.Shift(5);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey(true);
        }
    }
}
