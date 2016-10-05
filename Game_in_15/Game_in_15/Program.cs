using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_in_15
{
    class Program
    {
        static void Main(string[] args)
        { try
            {
                Game Fild = new Game(1, 5, 6, 12, 98, 0);
                Console.WriteLine(Fild.field[0, 1]);
                Console.WriteLine(Fild[0, 1]);
                Console.WriteLine(Fild.GetLocation(12)[0] + " " + Fild.GetLocation(12)[1]);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey(true);
        }
    }
}
