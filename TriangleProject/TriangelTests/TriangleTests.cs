﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleProject;
namespace TriangelTests
{
    [TestClass]
    public class TriangleTests
    {   
        

        [TestMethod]
        public void FromSides_ShouldCreateCorrectTriangle()
        {
           Triangle myTriangle = Triangle.From3Sides(3,4,5);
            Assert.AreEqual(myTriangle.side1, 3);
            Assert.AreEqual(myTriangle.side2, 4);
            Assert.AreEqual(myTriangle.side3, 5);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromSides_ShouldThrowExceptionWhenPassInvalidArgs()
        {
            Triangle.From3Sides(3, -7, 5);
        }

        [TestMethod]
        public void From2SidesAndAngle_ShouldCreateCorrectTriangle()
        {
            Triangle myTriangle = Triangle.From2SidesAndAngle(3, 4, 90);
            Assert.AreEqual(myTriangle.side1, 3);
            Assert.AreEqual(myTriangle.side2, 4);
            Assert.AreEqual(myTriangle.side3, 5);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void From2SidesAndAngle_ShouldThrowExceptionWhenPassInvalidArgs()
        {
            Triangle.From2SidesAndAngle(3, 7, 290);
           
        }
        
        [TestMethod]
        public void FromSideAnd2Angle_ShouldCreateCorrectTriangle()
        {
            Triangle myTriangle = Triangle.FromSideAnd2Angles(3, 30, 90);
            Assert.AreEqual(myTriangle.side1, 3);
            Assert.AreEqual( myTriangle.side2, 1.73, 1e-2);
            Assert.AreEqual(myTriangle.side3, 3.46, 1e-2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromSideAnd2Angle_ShouldThrowExceptionWhenPassInvalidArgs()
        {
            Triangle.FromSideAnd2Angles(3, 70, -290);

        }

        [TestMethod]
        public void Area_FromSides_ShouldCreateCorrectArea()
        {
            Triangle myTriangle = Triangle.From3Sides(3, 4, 5);
            myTriangle.Area();
            Assert.AreEqual(myTriangle.S, 6);
        }

        [TestMethod]
        public void Area_From2SidesAndAngle_ShouldCreateCorrectArea()
        {
            Triangle myTriangle = Triangle.From2SidesAndAngle(3, 4, 90);
            myTriangle.Area();
            Assert.AreEqual(myTriangle.S, 6);

        }

        [TestMethod]
        public void Area_FromSideAnd2Angle_ShouldCreateCorrectArea()
        {  Triangle myTriangle = Triangle.FromSideAnd2Angles(3, 60, 60);
            myTriangle.Area();
            Assert.AreEqual(myTriangle.S, 3.89, 10e-2);
        }
    }
}
