using ShapeCalc;
using ShapeCalc.Exception;

namespace ShapeCalcTests
{
    public class StaticAreaCalcTest
    {
        [Fact]
        public void TriangleGetShapeArea_ZeroNumbers_ReturnsException()
        {
            Assert.Throws<ShapeException>(() => AreaCalc.GetShapeArea(0, 0, 0));   
        }
    }
}