using ShapeCalc;
using ShapeCalc.Exception;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions;
using Xunit.Sdk;
using System.Reflection;


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