using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaShapeLibrary.UnitTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [DataRow(5, 3, 3, 4.15)]
        [DataRow(10, 15, 14, 67.71)]
        [DataRow(100, 150, 200, 7261.84)]
        public void WhenSides_ThenArea(float a, float b, float c, double expected)
        {
            //Arrange
            var triangle = new Triangle("Треугольник_1", a, b, c);

            //Act
            var result = triangle.CalculateArea();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(5, 12, 13)]
        [DataRow(17, 144, 145)]
        public void WhenSides_ThenTriangleStraight(float a, float b, float c)
        {
            //Arrange
            var triangle = new Triangle("Треугольник_2", a, b, c);

            //Act
            var result = triangle.IsStraightTriangle();

            //Assert
            Assert.IsTrue(result);
        }
    }
}
