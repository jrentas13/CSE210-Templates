using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("yellow", 4));
        shapes.Add(new Rectangle("red", 3, 5));
        shapes.Add(new Circle("blue", 2));

        foreach(Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine(area);
        }
    }
}