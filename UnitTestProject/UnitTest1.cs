using NUnit.Framework;
using TriangleSolver;

namespace UnitTestProject
{
    [TestFixture]
    public class TriangleTests
    {
       
        // Isosceles Triangle Tests
        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle1_ReturnsIsosceles()
        {
            int side1 = 5, side2 = 5, side3 = 3;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle2_ReturnsIsosceles()
        {
            int side1 = 4, side2 = 4, side3 = 6;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle3_ReturnsIsosceles()
        {
            int side1 = 7, side2 = 7, side3 = 5;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Isosceles triangle", result);
        }

        
    }
}
