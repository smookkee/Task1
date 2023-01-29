using ShapeCalc;
using ShapeCalc.Exception;
using ShapeCalc.Shapes;

namespace ShapeCalcTest
{
    public class StaticAreaCalcTests
    {
        #region Triangle tests
        [Fact]
        public void TriangleGetShapeArea_SetZero_ReturnsException()
        {
            Assert.Throws<ShapeException>(() => AreaCalc.GetShapeArea(0, 0, 0));
        }

        [Fact]
        public void TriangleGetShapeArea_SetNonExistentTriangle_ReturnsException()
        {
            Assert.Throws<ShapeException>(() => AreaCalc.GetShapeArea(1, 1, 10));
        }

        [Fact]
        public void TriangleGetShapeArea_SetRealTriangle_ReturnsSix()
        {
            var actual = AreaCalc.GetShapeArea(3, 4, 5);

            double expected = 6;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleGetShapeArea_SetRectangularTriangle_ReturnsTrue()
        {
            var actual = AreaCalc.IsTriangleRectangular(3, 4, 5);

            bool expected = true;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleGetShapeArea_SetNonRectangularTriangle_ReturnsFalse()
        {
            var actual = AreaCalc.IsTriangleRectangular(4, 4, 5);

            bool expected = false;

            Assert.Equal(expected, actual);
        }
        #endregion

        #region Circle tests
        [Fact]
        public void CircleGetShapeArea_SetZeroRadius_ReturnsException()
        {
            Assert.Throws<ShapeException>(() => AreaCalc.GetShapeArea(0));
        }

        [Fact]
        public void CircleGetShapeArea_SetNegativeRadius_ReturnsException()
        {
            Assert.Throws<ShapeException>(() => AreaCalc.GetShapeArea(-1));
        }

        [Fact]
        public void CircleGetShapeArea_SetRealCircle_ReturnsRightAnswer()
        {
            var actual = AreaCalc.GetShapeArea(100);

            double expected = 31415.926535897932;

            Assert.Equal(expected, actual);
        }
        #endregion

        #region Irregular polygon tests
        [Fact]
        public void IrregularPolygonGetShapeArea_SetLessThanThreeDots_ReturnsException()
        {
            List<Dot> dots = new List<Dot>
            {
                new Dot(0, 0),
                new Dot(0, 5)
            };

            Assert.Throws<ShapeException>(() => AreaCalc.GetShapeArea(dots));
        }

        [Fact]
        public void IrregularPolygonGetShapeArea_SetKnownPolygon_ReturnsTwentyFive()
        {
            List<Dot> dots = new List<Dot>
            {
                new Dot(0, 0),
                new Dot(0, 5),
                new Dot(5, 5),
                new Dot(5, 0)
            };

            var actual = AreaCalc.GetShapeArea(dots);

            double expected = 25;

            Assert.Equal(expected, actual);
        }
        #endregion
    }
}