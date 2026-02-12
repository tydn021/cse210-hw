using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> list = new List<Shape>();

        Square square = new Square(4, "Blue");
        list.Add(square);

        Circle circle = new Circle(3, "Green");
        list.Add(circle);

        Rectangle rect = new Rectangle(3, 5, "Red");
        list.Add(rect);

        foreach (Shape s in list)
        {
           double area = s.GetArea();
            string color = s.GetColor();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}