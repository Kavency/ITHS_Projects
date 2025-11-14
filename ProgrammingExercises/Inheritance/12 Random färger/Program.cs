// 12.Random färger
// Lägg till följande i Shape
//protected ConsoleColor color;
//Uppdatera sedan subklasserna med en variant (overload) av konstruktorn som även tar en färg.
//Använd dig av constructor chaining.
//Uppdatera PrintAll() så att raden skrivs ut i den färg som angavs när vardera shape skapades.
//Uppdatera loopen som initierar arrayen så att varje shape som skapas får en random färg.

Shape[] shapes = new Shape[10];

Random rnd = new();

for (int i = 0; i < shapes.Length; i++)
{
    if (rnd.Next(2) == 0)
    {
        shapes[i] = new Circle(rnd.Next(1, 10), (ConsoleColor)rnd.Next(1, 15));
    }
    else
    {
        shapes[i] = new Square(rnd.Next(1, 10), (ConsoleColor)rnd.Next(1, 16));
    }
}

Shape.PrintAllShapes(shapes);
Console.WriteLine();

public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
    protected ConsoleColor Colour { get; set; }
    public void Print()
    {
        Console.WriteLine(this);
    }
    public static void PrintAllShapes(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            if (shape.Colour != null)
                Console.ForegroundColor = (ConsoleColor)shape.Colour;
            
            Console.WriteLine(shape);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    public static void PrintAllCircles(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            if (shape is Circle)
                Console.WriteLine(shape);
        }
    }
}

public class Circle : Shape
{
    public override double Area { get; }
    public override double Circumference { get; }
    public double Radius { get; }

    public Circle(double radius) 
    {
        Radius = radius;

        // A = Pi * r^2
        Area = Math.PI * Math.Pow(radius, 2);

        // C = 2r * Pi
        Circumference = 2 * radius * Math.PI;
    }
    public Circle(double radius, ConsoleColor colour) : this (radius)
    {
        Colour = colour;
    }

    public override string ToString()
    {
        return $"A circle with radius {Radius:f2} has an area of {Area:f2} and a circumference of {Circumference:f2}.";
    }
}

public class Square : Shape
{
    public override double Area { get; }
    public override double Circumference { get; }
    public double Side { get; }

    public Square(double side)
    {
        Side = side;

        // A = side^2
        Area = Math.Pow(side, 2);

        // C = side * 4
        Circumference = side * 4;
    }
    public Square(double side, ConsoleColor colour) : this(side)
    {
        Colour = colour;
    }
    public override string ToString()
    {
        
        return $"A square with side {Side:f2} has an area of {Area:f2} and a circumference of {Circumference:f2}.";
    }
}
