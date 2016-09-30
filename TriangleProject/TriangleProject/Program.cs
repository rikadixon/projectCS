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
            while (action == 0)
            {
                try
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
                        Triangle DataFromUser = Triangle.From3Sides(First, Second, Third);
                        DataFromUser.Area();

                    }
                    if (action == 2)
                    {
                        Console.WriteLine("Введите две стороны и угол между ними");
                        First = Convert.ToInt32(Console.ReadLine());
                        Second = Convert.ToInt32(Console.ReadLine());
                        Third = Convert.ToInt32(Console.ReadLine());
                        Triangle DataFromUser = Triangle.From2SidesAndAngle(First, Second, Third);
                        DataFromUser.Area();
                        //  Console.WriteLine("Cтороны" + DataFromUser.side1 + " " + DataFromUser.side2 + " " + DataFromUser.side3 + " " + DataFromUser.semiperimeter + " " + DataFromUser.S);
                    }
                    if (action == 3)
                    {
                        Console.WriteLine("Введите два угла и одну сторону сторону между ними ");
                        First = Convert.ToInt32(Console.ReadLine());
                        Second = Convert.ToInt32(Console.ReadLine());
                        Third = Convert.ToInt32(Console.ReadLine());
                        Triangle DataFromUser = Triangle.FromSideAnd2Angles(First, Second, Third);
                        DataFromUser.Area();
                        //  Console.WriteLine("Cтороны"+ DataFromUser.side1+" "+ DataFromUser.side2 + " "+DataFromUser.side3 + " " + DataFromUser.semiperimeter+ " " + DataFromUser.S);
                    }
                    if (!(action == 1)&&!(action == 2)&&!(action == 3))
                    {
                        action = 0;
                        throw new Exception("Неверно введены данные");
                        //Console.WriteLine("Неверно введены данные");

                    }
                }
                catch (FormatException ex)
                {
                    action = 0;
                    Console.WriteLine("Ошибка: " + ex.Message + "\n\n");
                }
                catch (Exception exc) 
                {
                    Console.WriteLine("Ошибка: " + exc.Message + "\n\n");
                }
            }
            Console.ReadKey(true);

            }
        }
    }
