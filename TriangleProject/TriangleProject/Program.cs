using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var action = 0;
            double First, Second, Third;
            Triangle DataFromUser =new Triangle();
            while (action == 0)
            {
                Console.WriteLine("Введите номер действия:");
                Console.WriteLine("1)три стороны,2)2 стороны и угол между ними,3)два угла и сторона между ними");
                action = Convert.ToInt32(Console.ReadLine());

                if (action == 1)
                {
                    Console.WriteLine("Введите три стороны");
                    First = Convert.ToInt32(Console.ReadLine());
                    Second = Convert.ToInt32(Console.ReadLine());
                    Third = Convert.ToInt32(Console.ReadLine());
                    DataFromUser.From3Sides(First, Second, Third);
                    Console.WriteLine(" Площадь треугольника " + DataFromUser.Sqer());
                }
                if (action == 2)
                {
                    Console.WriteLine("Введите две стороны и угол между ними");
                    First = Convert.ToInt32(Console.ReadLine());
                    Second = Convert.ToInt32(Console.ReadLine());
                    Third = Convert.ToInt32(Console.ReadLine());
                    DataFromUser.From2SidesAndAngle(First, Second, Third);
                    Console.WriteLine(" Площадь треугольника "+DataFromUser.Sqer());
                    Console.WriteLine("Cтороны" + DataFromUser.side1 + " " + DataFromUser.side2 + " " + DataFromUser.side3 + " " + DataFromUser.semiperimeter + " " + DataFromUser.S);
                }
                if (action == 3)
                {
                    Console.WriteLine("Введите два угла и одну сторону сторону между ними ");
                    First = Convert.ToInt32(Console.ReadLine());
                    Second = Convert.ToInt32(Console.ReadLine());
                    Third = Convert.ToInt32(Console.ReadLine());
                    DataFromUser.FromSideAnd2Angles(First, Second, Third);
                    Console.WriteLine(" Площадь треугольника " + DataFromUser.Sqer());
                    Console.WriteLine("Cтороны"+ DataFromUser.side1+" "+ DataFromUser.side2 + " "+DataFromUser.side3 + " " + DataFromUser.semiperimeter+ " " + DataFromUser.S);
                }
                if(!(action == 1)&& !(action == 2)&& !(action == 3))
                {
                    Console.WriteLine("Не верно введено действие");
                    action = 0;
                }
            }
                Console.ReadKey(true);

            }
        }
    }
