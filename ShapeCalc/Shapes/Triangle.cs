using ShapeCalc.Exception;
using ShapeCalc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc.Shapes
{
    public class Triangle : BaseShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ShapeException();
            }

            if(((side1 + side2) < side3) || (side2 + side3) < side1 || (side1 + side3) < side2)
            {
                throw new ShapeException("Triangle does not exist");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double GetShapePerimeter()
        {
            return side1 + side2 + side3;
        }

        public double GetShapeArea()
        {
            double halfPerimetr = GetShapePerimeter()/2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - side1) * (halfPerimetr - side2) * (halfPerimetr - side3));
        }

        public bool IsRectangular()
        {
            double hypotenuse = side1 > side2 ? (side1 > side3 ? side1 : side3) : (side2 > side3 ? side2 : side3);
            return (hypotenuse * hypotenuse) * 2 == side1 * side1 + side2 * side2 + side3 * side3;
        }
    }
}
