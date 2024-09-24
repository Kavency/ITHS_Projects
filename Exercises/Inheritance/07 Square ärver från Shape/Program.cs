// 7.Square ärver också från Shape
// Skapa även en klass Square som ärver från Shape.
// Implementera Square på så vis att koden nedan ...
//
// var square = new Square(5);
// Console.WriteLine(square);
// Console.WriteLine($"Area: {square.Area:f2}");
// Console.WriteLine($"Circumference: {square.Circumference:f2}");
// ... ger följande utskrift:
//
// A square with side 5
// Area: 25,00
// Circumference: 20,00

Circle circle = new(5);

Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");

Console.WriteLine();

Square square = new(5);

Console.WriteLine(square);
Console.WriteLine($"Area: {square.Area:f2}");
Console.WriteLine($"Circumference: {square.Circumference:f2}");


public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
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

    public override string ToString()
    {
        return $"A circle with a radius of {Radius}.";
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

    public override string ToString()
    {
        return $"A square with a side of {Side}";
    }
}
