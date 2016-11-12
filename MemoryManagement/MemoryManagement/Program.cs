using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MemoryManagement
{
    class Program
    {
        static void Main1(string[] args)
        {
            var timer = new Timer();
            using (timer.Start())
            {
                for (var i = 0; i < 25000; i++)
                {
                    for (var j = 0; j < 25000; j++)
                    {
                        var k = i + j;
                    }
                }
            }
            Console.WriteLine(timer.ElapsedMilliseconds);

            using (timer.Continue())
            {
                for (var i = 0; i < 25000; i++)
                {
                    for (var j = 0; j < 25000; j++)
                    {
                        var k = i + j;
                    }
                }
            }
            Console.WriteLine(timer.ElapsedMilliseconds);
            Console.ReadKey(true);
        }
    }
}
