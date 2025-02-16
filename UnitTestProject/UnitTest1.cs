using NUnit.Framework;
using TriangleSolver;

namespace UnitTestProject
{
    [TestFixture]
    public class TriangleTests
    {
        // Equilateral Triangle Test
        [Test]
        public void AnalyzeTriangle_ValidEquilateral_ReturnsEquilateral()
        {
            // Arrange
            int side1 = 3, side2 = 3, side3 = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        }

        
    }
}
