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
        [TestMethod]
        public void TriangleIsNotEquilateral()
        {
            //Arrange
            Triangle t = new Triangle(1, 2, 3);
            //Act
            bool result = t.isEquilateral();
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TriangleIsNotIsosceles()
        {
            //Arrange
            Triangle t = new Triangle(10, 11, 15);
            //Act
            bool result = t.isIsosceles();
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TriangleIsNotScalene()
        {
            //Arrange
            Triangle t = new Triangle(10, 10, 15);
            //Act
            bool result = t.isScalene();
            //Assert
            Assert.IsFalse(result);
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
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PointAbcNoEqualCoords1()
        {
            Point a = new Point(0, 0);
            Point b = new Point(5, 0);
            Triangle t = new Triangle(a, a, b);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PointAbcNoEqualCoords2()
        {
            Point a = new Point(0, 0);
            Point b = new Point(5, 0);
            Triangle t = new Triangle(a, b, a);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PointAbcNoEqualCoords3()
        {
            Point a = new Point(0, 0);
            Point b = new Point(5, 0);
            Triangle t = new Triangle(b, a, a);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PointArrayNoEqualCoords1()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 3);
            Point[] points = { a, a, b };
            Triangle t = new Triangle(points);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PointArrayNoEqualCoords2()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 3);
            Point[] points = { a, b, a };

            Triangle t = new Triangle(points);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PointArrayNoEqualCoords3()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 3);

            Point[] points = { a, a, b };
            Triangle t = new Triangle(points);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PointArrayRejectsMoreThanThree()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 1);
            Point c = new Point(13, 1);
            Point d = new Point(12, 1);


            Point[] points = { a, b, c, d };
            Triangle t = new Triangle(points);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PointArrayRejectsLessThanThree()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 1);

            Point[] points = { a, b};
            Triangle t = new Triangle(points);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DoubleArrayRejectsMoreThanThree()
        {
            double[] sides = { 1, 2, 3, 4 };
            Triangle t = new Triangle(sides);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DoubleArrayRejectsLessThanThree()
        {
            double[] sides = { 1, 2};
            Triangle t = new Triangle(sides);
        }


        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TriangleDisallowNonIntegerInput()
        //{
        //    Triangle t = new Triangle("a", 1, 1);
        //}
    }
}
