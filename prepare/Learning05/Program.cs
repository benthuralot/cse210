using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue",  20);
        //Console.WriteLine($"This SQUARE is the color {square.GetColor()} with a area of {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Red", 20, 10);
        //Console.WriteLine($"This RECTANGLE is the color {rectangle.GetColor()} with a area of {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 20);
        //Console.WriteLine($"This CIRCLE is the color {circle.GetColor()} with a area of {circle.GetArea()}");

        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        

        foreach (Shapes shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
    }
}