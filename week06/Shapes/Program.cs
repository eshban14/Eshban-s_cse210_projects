using Shapes;

class Program
{
    static void Main()
    {
        Shape square = new Square("Red", 4);
        Shape rectangle = new Rectangle("Blue", 5, 6);
        Shape circle = new Circle("Green", 3);

        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
