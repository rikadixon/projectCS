using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleProject
{
    public class Triangle
    {


        public double side1 { get; private set; }
        public double side2 { get; private set; }
        public double side3 { get; private set; }
        public double S { get; private set; }

    private Triangle() { }

        public static Triangle From3Sides(double Sidefromuser1, double Sidefromuser2, double Sidefromuser3)
        {
            Triangle TriangleObject = new Triangle();
            if ((Sidefromuser1 > 0) && (Sidefromuser2 > 0) && (Sidefromuser3 > 0))
            {
                TriangleObject.side1 = Sidefromuser1;
                TriangleObject.side2 = Sidefromuser2;
                TriangleObject.side3 = Sidefromuser3;
                return TriangleObject;
            }
            else
            {
                throw new Exception("Неверно введены данные");
            }
        }

        public static Triangle From2SidesAndAngle(double Sidefromuser1, double Sidefromuser2, double Fromuserangle)
        {
            Triangle TriangleObject = new Triangle();
                if ((Fromuserangle <= 180) && (Fromuserangle >= 0) && (Sidefromuser1 > 0) && (Sidefromuser2 > 0))
                {
                    TriangleObject.side1 = Sidefromuser1;
                    TriangleObject.side2 = Sidefromuser2;
                    double radian = Fromuserangle * Math.PI / 180;
                    TriangleObject.side3 = Math.Sqrt(Math.Pow(TriangleObject.side1, 2) + Math.Pow(TriangleObject.side2, 2) - 2 * TriangleObject.side1 * TriangleObject.side2 * Math.Cos(radian));
                    return TriangleObject;
                }
                else
                {
                    throw new Exception("Неверно введены данные_");
                }
                }
           


        public static Triangle FromSideAnd2Angles(double Sidefromuser1,double Fromuserangle, double Fromuserangle2)
        {
            Triangle TriangleObject = new Triangle();
            if ((Fromuserangle <= 180) && (Fromuserangle >= 0) && (Fromuserangle2 <= 180) && (Fromuserangle2 >= 0) && (Sidefromuser1 > 0))
            {
                TriangleObject.side1 = Sidefromuser1;
                double angle3 = 180 - Fromuserangle - Fromuserangle2;
                double radian1 = angle3 * Math.PI / 180, radian2= Fromuserangle * Math.PI / 180, radian3 = Fromuserangle2 * Math.PI / 180;
                TriangleObject.side2 = (TriangleObject.side1 *Math.Sin(radian2))/ Math.Sin(radian1);
                TriangleObject.side3 = (TriangleObject.side1 * Math.Sin(radian3)) / Math.Sin(radian1);
                return TriangleObject;
            }
            else
            {
                throw new Exception("Неверно введены данные");

            }
        }
        
        public void Area()
        {   
            if ((side1 == 0) && (side2 == 0) && (side3 == 0)) {
                throw new Exception("Неверно задан треугольник");
                
            }
            else
            {
                double semiperimeter;
                semiperimeter = (side1 + side2 + side3) / 2;
                S=Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            }
        }
    }
}

