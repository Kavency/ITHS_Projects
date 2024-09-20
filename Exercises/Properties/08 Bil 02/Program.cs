// 8.Bil 2
// Skriv en ny klass som representerar en bil. Varje bil ska kunna ha en färg som 
// representeras av en ConsoleColor, samt en längd. När man instansierar en bil så 
// ska den få en random färg, och en random längd (mellan 3 och 5 meter). Instansiera 
// 1000 bilar och spara i en array. Skapa en funktion som tar en array av bilar och 
// returnerar den sammanlagda längden av alla gröna bilar.

Car[] cars = new Car[1000];

for(int i = 0; i < cars.Length; i++)
{
    Car car = new();
    cars[i] = car;
}

Console.WriteLine(GetLength(cars));




double GetLength(Car[] cars)
{
    double returnValue = 0D;

    foreach(Car car in cars)
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
}