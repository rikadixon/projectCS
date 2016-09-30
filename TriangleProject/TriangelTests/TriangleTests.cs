using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangelTests
{
    [TestClass]
    public class TriangleTests
    {   

        [TestMethod]
        public void TestFrom3Sides()
        {  
        }

        //[TestMethod]
        //public void TestFrom2SidesAndAngle()
        //{   double side1 = 3, side2 = 4, angle = 90;
        //    Assert.AreEqual(3, result.side1, 10e-6);
        //    Assert.AreEqual(4, result.side2, 10e-6);
        //    Assert.AreEqual(5, result.side3, 10e-6);
        //}

        //[TestMethod]
        //public void TestFromSideAnd2Angles()
        //{   double side1 = 3, angle1 = 90, angle2 = 30;
        //    result.FromSideAnd2Angles( angle1, angle2,side1);
        //    Assert.AreEqual(side1, result.side1);
        //    Assert.AreEqual(3.46, result.side2, 1e-2);
        //    Assert.AreEqual(1.73, result.side3, 1e-2);
        //}

        //[TestMethod]
        //public void TestNegativeSides()
        //{   double side1 = 3, side2 = -4, side3 = 5;
        //    result.From3Sides(side1, side2, side3);
        //    Assert.AreEqual(0, result.side1);
        //    Assert.AreEqual(0, result.side2);
        //    Assert.AreEqual(0, result.side3);
        //}

        //[TestMethod]
        //public void TestWrongNegativeAnglesFrom2SidesAndAngle()
        //{ double side1 = 3, side2 = 4, angle = -40;
        //    result.From2SidesAndAngle(side1, side2, angle);
        //    Assert.AreEqual(0, result.side1);
        //    Assert.AreEqual(0, result.side2);
        //    Assert.AreEqual(0, result.side3);
        //}
        //[TestMethod]
        //public void TestWrongAnglesFrom2SidesAndAngle()
        //{
        //    double side1 = 3, side2 = 4, angle = 200;
        //    result.From2SidesAndAngle(side1, side2, angle);
        //    Assert.AreEqual(0, result.side1);
        //    Assert.AreEqual(0, result.side2);
        //    Assert.AreEqual(0, result.side3);
        //}

        //[TestMethod]
        //public void TestWrongAnglesFromSideAnd2Angles()
        //{   double side1 = 3, angle1 = -4, angle2 = 300;
        //    result.FromSideAnd2Angles(side1, angle1, angle2);
        //}
    }
}
