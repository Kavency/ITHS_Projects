
// 6. Circle som ärver från Shape
// Utgå från följande kod:
// public abstract class Shape
// {
//     public abstract double Area { get; }
//     public abstract double Circumference { get; }
// }
//
// Skapa en klass Circle som ärver från klassen ovan.
// Implementera Circle på så vis att koden nedan ...
//
// var circle = new Circle(5);
// Console.WriteLine(circle);
// Console.WriteLine($"Area: {circle.Area:f2}");
// Console.WriteLine($"Circumference: {circle.Circumference:f2}");
// ... ger följande utskrift:
//
// A circle with radius 5
// Area: 78,54
// Circumference: 31,42

Circle circle = new(5);

Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");

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

    public Circle(int radius)
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
