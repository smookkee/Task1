using ShapeCalc.Exception;
using ShapeCalc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc.Shapes
{
    public class Circle : BaseShape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ShapeException();
            }

            this.radius = radius;
        }

        public double GetShapePerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public double GetShapeArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
