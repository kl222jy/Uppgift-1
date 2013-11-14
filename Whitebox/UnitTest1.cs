using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace Whitebox
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TF1_TriangleIsEquilateral()
        {
            //Arrange
            Triangle t = new Triangle(1, 1, 1);
            //Act
            bool result = t.isEquilateral();
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TF2_TriangleIsScalene()
        {
            //Arrange
            Triangle t = new Triangle(1, 1, 2);
            //Act
            bool result = t.isScalene();
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TF3_TriangleIsIsosceles()
        {
            //Arrange
            Triangle t = new Triangle(1, 2, 3);
            //Act
            bool result = t.isIsosceles();
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TF4_TriangleNoZeroSides()
        {
            //Arrange
            Triangle t = new Triangle(0, 1, 1);
            //Act
            bool result = true;                     //Kontrollera att triangeln blir ogiltig
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TF5_TriangleNoNegativeSides()
        {
            //Arrange
            Triangle t = new Triangle(-1, 1, 1);
            //Act
            bool result = true;                     //kontrollera att triangeln blir ogiltig
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TF6_TriangleDisallowNonIntegerInput()
        {
            //Arrange
            //Triangle t = new Triangle("a", 1, 1);
            //Act
            bool result = false;                    //kontrollera att inmatning av värden annat än siffror inte tillåts
            //Assert
            Assert.IsTrue(result);
        }
    }
}
