// 9.Lägg till statisk metod
// Lägg till en statisk metod på klassen i uppgift 8. Metoden ska ta en 
// bil som inparameter och returnera en array med 10 bilar i samma färg 
// som bilen man skickat in, men med olika längd.

Car[] cars = new Car[1000];

for (int i = 0; i < cars.Length; i++)
{
    Car car = new();
    cars[i] = car;
}

Car[] tenCars = new Car[10];

tenCars = Car.GetCars(cars[0]);

Console.WriteLine($"Original car has a length of {cars[0].Length} and the colour {cars[0].Colour}");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Ten new cars has the folowing properties:");
foreach (var car in tenCars)
{
    Console.WriteLine($"Length: {car.Length} Colour: {car.Colour}");
}


double GetLength(Car[] cars)
{
    double returnValue = 0D;

    foreach (Car car in cars)
    {
        returnValue += car.Length;
    }

    return returnValue;
}


class Car
{
    private ConsoleColor _colour;
    private double _length;

    public ConsoleColor Colour { get { return _colour; } }
    public double Length { get { return _length; } }

    public Car()
    {
        Random rnd = new();
        _colour = (ConsoleColor)rnd.Next(0, 16);
        _length = rnd.Next(3, 6);
    }

    public static Car[] GetCars(Car car)
    {
        Car[] newCars = new Car[10];

        Random rnd = new();

        for (int i = 0; i < newCars.Length; i++)
        {
            newCars[i] = new Car();

            do
            {
                newCars[i]._length = rnd.Next(3, 6);
            } while (newCars[i].Length == car.Length );
            do
            {
                newCars[i]._colour = (ConsoleColor)rnd.Next(0, 16);
            } while (newCars[i].Colour != car.Colour);
        }

        return newCars;
    }
}