using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square square = new Square(10, "red");
        Circle circle = new Circle(10, "Blue");
        Rectangle rectangle = new Rectangle(10, 23, "Green");
        
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The Area for {shape} is {shape.GetArea()}");
            Console.WriteLine($"The color for {shape} is {shape.GetColor()}");
            Console.WriteLine(" ");
        }

       
        
       ;


    }
}