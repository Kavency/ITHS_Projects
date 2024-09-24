// 9.En array av cirklar och kvadrater
// Shape[] shapes = new Shape[10];
// Skriv en loop som slumpmässigt initerar alla element i arrayen med antingen cirklar 
// med 0 < radie < 10, eller kvadrater med 0 < sida < 10.

// Sätt en breakpoint efter loopen och inspektera arrayen i Visual Studios debugger.



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
