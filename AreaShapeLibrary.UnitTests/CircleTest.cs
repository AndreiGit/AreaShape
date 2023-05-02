using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaShapeLibrary.UnitTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [DataRow(10, 314.16)]
        [DataRow(55, 9503.32)]
        [DataRow(1522, 7277449.12)]
        public void WhenRadius_ThenArea(float radius, double expected)
        {
            // Arrange
            var circle = new Circle("Круг_1", radius);

            // Act
            var result = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}