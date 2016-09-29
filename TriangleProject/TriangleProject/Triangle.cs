using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleProject
{
    public class Triangle
    {
        public double side1, side2, side3, S, semiperimeter;
        public Triangle() { }
        public Triangle From3Sides(double sidefromuser1, double sidefromuser2, double sidefromuser3)
        {
            if ((sidefromuser1 > 0) && (sidefromuser2 > 0) && (sidefromuser3 > 0))
            {
                side1 = sidefromuser1;
                side2 = sidefromuser2;
                side3 = sidefromuser3;
                return new Triangle();
            }
            else
            {
                Console.WriteLine("Неверно введены данные");
                return new Triangle();
            }
        }

        public Triangle From2SidesAndAngle(double sidefromuser1, double sidefromuser2, double fromuserangle)
        {
            if ((fromuserangle <= 180) && (fromuserangle >= 0) && (sidefromuser1 > 0) && (sidefromuser2 > 0))
            {
                side1 = sidefromuser1;
                side2 = sidefromuser2;
                double radian = fromuserangle * Math.PI / 180;
                side3 = Math.Sqrt(Math.Pow(side1,2) + Math.Pow(side2, 2) - 2 * side1 * side2 * Math.Cos(radian));
                return new Triangle();
            }
            else
            {
                Console.WriteLine("Неверно введены данные");
                return new Triangle();
            }
        }

        public Triangle FromSideAnd2Angles(double fromuserangle, double fromuserangle2, double sidefromuser1)
        {
            if ((fromuserangle <= 180) && (fromuserangle >= 0) && (fromuserangle2 <= 180) && (fromuserangle2 >= 0) && (sidefromuser1 > 0))
            {
                side1 = sidefromuser1;
                double angle3 = 180 - fromuserangle - fromuserangle2;
                double radian1 = angle3 * Math.PI / 180, radian2= fromuserangle * Math.PI / 180, radian3 = fromuserangle2 * Math.PI / 180; 
                side2 = (side1 *Math.Sin(radian2))/ Math.Sin(radian1);
                side3 = (side1* Math.Sin(radian3)) / Math.Sin(radian1);
                return new Triangle();
            }
            else
            {
                Console.WriteLine("Неверно введены данные");
                return new Triangle();
            }
        }
        public double Sqer()
        {
            if ((side1 == 0) && (side2 == 0) && (side3 == 0)) {
                Console.WriteLine("Неверно задан треугольник");
                return 0;
            }
            else
            {
               semiperimeter = (side1 + side2 + side3) / 2;
                S = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
                return S;
            }
        }
    }
}

