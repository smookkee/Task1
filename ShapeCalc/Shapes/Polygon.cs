using ShapeCalc.Exception;
using ShapeCalc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc.Shapes
{
    public class IrregularPolygon : BaseShape
    {
        private List<Dot> dots;

        public IrregularPolygon(List<Dot> dots)
        {
            if (dots.Count < 3)
            {
                throw new ShapeException("At least 3 parameters required");
            }

            this.dots = dots;
        }

        public double GetShapePerimeter()
        {
            return dots.Take(dots.Count - 1).Select((p, i) => Math.Sqrt(Math.Pow((dots[i + 1].X - p.X),2) + Math.Pow((dots[i + 1].Y - p.Y),2)) ).Sum() 
                + Math.Sqrt(Math.Pow((dots.Last().X  - dots[0].X), 2) + Math.Pow((dots.Last().Y - dots[0].Y), 2));
        }

        public double GetShapeArea()
        {
            return Math.Abs(dots.Take(dots.Count - 1).Select((p, i) => (dots[i + 1].X - p.X) * (dots[i + 1].Y + p.Y)).Sum() / 2);
        }        
    }

    public class Dot
    {
        public double X { get;}
        public double Y { get; }
        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
