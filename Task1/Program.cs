using ShapeCalc;
using ShapeCalc.Shapes;

List<Dot> arr = new List<Dot>();

arr.Add(new Dot(0, 0));
arr.Add(new Dot(0, 5));
arr.Add(new Dot(0, 5));
//arr.Add(new Dot(5, 0));

Console.WriteLine(AreaCalc.GetShapeArea(100));
Console.ReadLine();