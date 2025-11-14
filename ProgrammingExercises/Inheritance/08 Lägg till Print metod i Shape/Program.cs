// 8.Lägg till Print() i Shape
// Uppdatera (endast) den abstrakta basklassen med en Print() method.
//
// När detta är gjort ska koden nedan ...
//
// var square = new Square(3.2);
// square.Print();
//
// var circle = new Circle(4.5);
// circle.Print();
// ... ge följande utskrift:
//
// A square with side 3,2 has an area of 10,24 and a circumference of 12,80.
// A circle with radius 4,5 has an area of 63,62 and a circumference of 28,27.


Circle circle = new(4.5);
circle.Print();

Console.WriteLine();

Square square = new(3.2);
square.Print();


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
