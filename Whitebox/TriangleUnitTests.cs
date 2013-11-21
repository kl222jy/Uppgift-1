using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace Whitebox
{
    [TestClass]
    public class TriangleUnitTests
    {
        //Constructor tests
        [TestMethod]
        public void DoubleAbcConstructor()
        {
            //Arrange
            Triangle t = new Triangle(1, 1, 1);
            //Act
            bool result = t.isEquilateral();
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void DoubleArrayConstructor()
        {
            //Arrange
            double[] sides = {1, 1, 1};
            Triangle t = new Triangle(sides);
            //Act
            bool result = t.isEquilateral();
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PointsAbcConstructor()
        {
            //Arrange
            Point a = new Point(0, 0);
            Point b = new Point(5, 0);
            Point c = new Point(0, 5);

            Triangle t = new Triangle(a, b, c);
            //Act
            bool result = t.isIsosceles();
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PointsArrayConstructor()
        {
            //Arrange
            Point a = new Point(0, 0);
            Point b = new Point(5, 0);
            Point c = new Point(0, 5);
            Point[] points = { a, b, c };

            Triangle t = new Triangle(points);
            //Act
            bool result = t.isIsosceles();
            //Assert
            Assert.IsTrue(result);
        }

        //Functiontests
        [TestMethod]
        public void TriangleIsEquilateral()
        {
            //Arrange
            Triangle t = new Triangle(1, 1, 1);
            //Act
            bool result = t.isEquilateral();
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TriangleIsIsosceles()
        {
            //Arrange
            Triangle t = new Triangle(10, 10, 15);
            //Act
            bool result = t.isIsosceles();
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TriangleIsScalene()
        {
            //Arrange
            Triangle t = new Triangle(10, 20, 15);
            //Act
            bool result = t.isScalene();
            //Assert
            Assert.IsTrue(result);
        }

        //Input tests
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DoubleAbcNoZeroSides()
        {
            Triangle t = new Triangle(0, 1, 1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DoubleArrayNoZeroSides()
        {
            double[] sides = { 0, 1, 1 };
            Triangle t = new Triangle(sides);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DoubleAbcNoNegativeSides()
        {
            Triangle t = new Triangle(-1, 1, 1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DoubleArrayNoNegativeSides()
        {
            double[] sides = { -1, 1, 1 };
            Triangle t = new Triangle(sides);
        }
        [ExpectedException(typeof(ArgumentException))]
        public void PointAbcNoEqualCoords()
        {
            Point a = new Point(0, 0);
            Point b = new Point(5, 0);
            Point c = new Point(0, 0);
            Triangle t = new Triangle(a, b, c);
        }
        [ExpectedException(typeof(ArgumentException))]
        public void PointArrayNoEqualCoords()
        {
            Point a = new Point(1, 1);
            Point b = new Point(1, 1);
            Point c = new Point(1, 1);
            Point[] points = { a, b, c };
            Triangle t = new Triangle(points);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TriangleDisallowNonIntegerInput()
        //{
        //    Triangle t = new Triangle("a", 1, 1);
        //}
    }
}
