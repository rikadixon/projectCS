using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleProject
{
    public class Triangle
    {
        double Side1, Side2, Side3, S;
        public Triangle() { }
        //Triangle TriangleObject = new Triangle();
        public static Triangle From3Sides(double sidefromuser1, double sidefromuser2, double sidefromuser3)
        {
            Triangle TriangleObject = new Triangle();
                if ((sidefromuser1 > 0) && (sidefromuser2 > 0) && (sidefromuser3 > 0))
                {
                    TriangleObject.Side1 = sidefromuser1;
                    TriangleObject.Side2 = sidefromuser2;
                    TriangleObject.Side3 = sidefromuser3;
                    return TriangleObject;
                }
            else
            {
                throw new Exception("Неверно введены данные");
                //Console.WriteLine("Неверно введены данные");

            }
        }

        public static Triangle From2SidesAndAngle(double sidefromuser1, double sidefromuser2, double fromuserangle)
        {
            Triangle TriangleObject = new Triangle();
                if ((fromuserangle <= 180) && (fromuserangle >= 0) && (sidefromuser1 > 0) && (sidefromuser2 > 0))
                {
                    TriangleObject.Side1 = sidefromuser1;
                    TriangleObject.Side2 = sidefromuser2;
                    double radian = fromuserangle * Math.PI / 180;
                    TriangleObject.Side3 = Math.Sqrt(Math.Pow(TriangleObject.Side1, 2) + Math.Pow(TriangleObject.Side2, 2) - 2 * TriangleObject.Side1 * TriangleObject.Side2 * Math.Cos(radian));
                    return TriangleObject;
                }
                else
                {
                    throw new Exception("Неверно введены данные_");
                    //Console.WriteLine("Неверно введены данные");
                }
      
                }
           


        public static Triangle FromSideAnd2Angles(double fromuserangle, double fromuserangle2, double sidefromuser1)
        {
            Triangle TriangleObject = new Triangle();
            if ((fromuserangle <= 180) && (fromuserangle >= 0) && (fromuserangle2 <= 180) && (fromuserangle2 >= 0) && (sidefromuser1 > 0))
            {
                TriangleObject.Side1 = sidefromuser1;
                double angle3 = 180 - fromuserangle - fromuserangle2;
                double radian1 = angle3 * Math.PI / 180, radian2= fromuserangle * Math.PI / 180, radian3 = fromuserangle2 * Math.PI / 180;
                TriangleObject.Side2 = (TriangleObject.Side1 *Math.Sin(radian2))/ Math.Sin(radian1);
                TriangleObject.Side3 = (TriangleObject.Side1 * Math.Sin(radian3)) / Math.Sin(radian1);
                return TriangleObject;
            }
            else
            {
                throw new Exception("Неверно введены данные");
                //Console.WriteLine("Неверно введены данные");

            }
        }
        
        public double Area()
        {   
            if ((Side1 == 0) && (Side2 == 0) && (Side3 == 0)) {
                throw new Exception("Неверно задан треугольник");
                
            }
            else
            {
                double semiperimeter;
                semiperimeter = (Side1 + Side2 + Side3) / 2;
                S = Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));
                Console.WriteLine(" Площадь треугольника " + S);
                return S;
            }
        }
    }
}

