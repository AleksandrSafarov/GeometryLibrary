using GeometryLibrary;

namespace UnitTestGeometryLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void CheckCircleArea()
        {
            double result = GeometryCalculator.CalculateCircleArea(5.0);
            Assert.Equal(78.53981633974483, result);
        }

        [Fact]
        public void CheckTriangleArea()
        {
            double result = GeometryCalculator.CalculateTriangleArea(3, 4, 5);
            Assert.Equal(6, result);
        }

        [Fact]
        public void CheckTriangleRightAngled()
        {
            bool result = GeometryCalculator.IsTriangleRightAngled(3, 4, 5);
            Assert.True(result);
        }

        [Fact]
        public void CheckTriangleNotRightAngled()
        {
            bool result = GeometryCalculator.IsTriangleRightAngled(5, 3, 5);
            Assert.False(result);
        }
    }
}