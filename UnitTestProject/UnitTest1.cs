using NUnit.Framework;
using TriangleSolver;

namespace UnitTestProject
{
    [TestFixture]
    public class TriangleTests
    {
        
        // Scalene Triangle Tests
        [Test]
        public void AnalyzeTriangle_ScaleneTriangle1_ReturnsScalene()
        {
            int side1 = 3, side2 = 4, side3 = 5;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle2_ReturnsScalene()
        {
            int side1 = 6, side2 = 8, side3 = 10;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle3_ReturnsScalene()
        {
            int side1 = 7, side2 = 9, side3 = 11;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle4_ReturnsScalene()
        {
            int side1 = 12, side2 = 15, side3 = 17;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle5_ReturnsScalene()
        {
            int side1 = 9, side2 = 14, side3 = 17;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        
    }
}
