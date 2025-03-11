using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle("Red", 3));
        shapes.Add(new Square("Green", 5));
        shapes.Add(new Rectangle("Purple", 7,5));

        foreach(Shape shape in shapes) {
            double area = shape.GetArea();

            Console.WriteLine($"{shape.GetColor()} - {area}");
        }
    }
}