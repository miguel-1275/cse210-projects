using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapesList = new List<Shape>();

        shapesList.Add(new Circle("blue", 10));
        shapesList.Add(new Square("purple", 4));
        shapesList.Add(new Rectangle("red", 12, 3));

        foreach (Shape s in shapesList)
        {
            DisplayArea(s);
        }
    }

    public static void DisplayArea(Shape shape)
    {
        Console.WriteLine($"Figure color: {shape.GetColor()}");
        Console.WriteLine($"Area: {shape.GetArea()}");
    }
}