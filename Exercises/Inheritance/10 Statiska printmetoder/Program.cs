// 10.Statiska printmetoder
// Lägg till en statisk metod PrintAll() i Shape som anropar Print() på alla shapes i en array.
//
// Lägg även till en statisk metod PrintCircles() som endast anropar Print() på alla cirklar i en array.
// Prova sedan att köra följande kod:
//
// Shape.PrintAll(shapes);
// Console.WriteLine();
// Shape.PrintCircles(shapes);
// (där shapes är arrayen från uppgift 9)

// Ovanstående ska skriva ut först alla shapes i arrayen, följt av blankrad, följt av alla circles i arrayen.

Shape[] shapes = new Shape[10];

Random rnd = new();

for (int i = 0; i < shapes.Length; i++)
{
    if (rnd.Next(2) == 0)
    {
        shapes[i] = new Circle(rnd.Next(1, 10));
    }
    else
    {
        shapes[i] = new Square(rnd.Next(1, 10));
    }
}

foreach (var shape in shapes)
{
    Console.WriteLine(shape);
}

public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
    public void Print()
    {
        Console.WriteLine(this);
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

    public override string ToString()
    {
        return $"A square with side {Side:f2} has an area of {Area:f2} and a circumference of {Circumference:f2}.";
    }
}
