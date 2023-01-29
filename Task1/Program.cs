using ShapeCalc;
using ShapeCalc.Shapes;

List<Dot> arr = new List<Dot>();

arr.Add(new Dot(0, 0));
arr.Add(new Dot(0, 5));
arr.Add(new Dot(0, 5));
//arr.Add(new Dot(5, 0));


var shape = new IrregularPolygon(arr);

Console.WriteLine(shape.GetShapePerimeter());

Console.WriteLine(shape.GetShapeArea());
Console.ReadLine();