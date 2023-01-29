using ShapeCalc.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc
{
    static public class AreaCalc
    {
        /// <summary>
        /// Get triangle area by three sides
        /// </summary>
        static public double GetShapeArea(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3).GetShapeArea();
        }

        /// <summary>
        /// Get circle area by radius
        /// </summary>
        static public double GetShapeArea(double radius)
        {
            return new Circle(radius).GetShapeArea();
        }

        /// <summary>
        /// Get Irregular Polygon area by List of Dots
        /// </summary>
        static public double GetShapeArea(List<Dot> dots)
        {
            return new IrregularPolygon(dots).GetShapeArea();
        }
    }
}
