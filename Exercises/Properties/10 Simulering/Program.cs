// 10.Simulering
// Uppdatera konstruktorn på klassen i uppgift 8 (och 9) så att bilen 
// även får en random hastighet (mellan 60 och 240 km/h). Skriv en metod
// DriveForOneHour() som uppdaterar en property Distance med total körsträcka. 
// Distance ska alltså initieras på 0, och sedan ökar för varje gång man anropar
// DriveForOneHour(). Lägg sedan till en metod GetGraph() som returnerar en string
// på 20 tecken som representerar en körsträcka på 1000 mil och visar bilens 
// position enligt exempel: “| ------x---------- -|”. (‘x’ är alltså bilens 
// position mellan start och mål (1000 mil).

// Skriv sedan ett program som simulerar att 10 bilar åker 1000 mil i olika hastighet 
// där varje bils position, samt dess exakta körda distans (i text) uppdateras en gång 
// i sekunden. (En sekund i simuleringen motsvarar alltså en timma i verkligheten).

Console.CursorVisible = false;

Car[] cars = new Car[10];

for (int i = 0; i < cars.Length; i++)
{
    do
    {
        cars[i] = new();
    } while (cars[i].Colour == 0);
}


while (true)
{
    int carNo = 1;
    string text1 = "Car no";
    string text2 = "Position on track";
    string text3 = "Speed";

    Console.Clear();

    Console.WriteLine("---------------------------------------");
    Console.Write("{0,-9}", "| Car no ") ;
    Console.Write("{0,-23}", "| Position on track  |") ;
    Console.WriteLine("{0,-8}", "Speed |") ;
    Console.WriteLine("---------------------------------------");

    foreach (var car in cars)
    {

        car.DriveForOneHour();

        Console.Write("{0,-9}", carNo);
        Console.ForegroundColor = car.Colour;
        Console.Write("{0,-23}", car.GetGraph());
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("{0,-8}", car.Speed);

        carNo++;
    }
    
    
    Thread.Sleep(1000);
}


class Car
{
    private ConsoleColor _colour;
    private double _length;
    private int _speed;
    private int _distance;
    private int _currentPos = 1;
    private int _nextDistance = 500;
    private string _output = "|X-------------------|";

    public ConsoleColor Colour { get { return _colour; } }
    public double Length { get { return _length; } }
    public int Speed { get { return _speed; } }
    public int Distance { get { return _distance; } }

    public Car()
    {
        Random rnd = new();
        _colour = (ConsoleColor)rnd.Next(0, 16);
        _length = rnd.Next(3, 6);
        _speed = rnd.Next(60, 241);
        _distance = 0;
    }

    public void DriveForOneHour()
    {
        _distance += Speed;
    }

    public string GetGraph()
    {
        // 10000km / 20tecken = 500km per tecken.
        // 20 / (10000 / _speed)

        for (int i = 0; i < 20; i++)
        {

            if(_currentPos >= 19)
            {
                _currentPos = 19;
            }

            if (_distance >= _nextDistance && i > 0)
            {
                _output = _output.Remove(_currentPos, 2);
                _output = _output.Insert(_currentPos, "-");
                _output = _output.Insert(_currentPos + 1, "X");

                _nextDistance += 500; // Remove use of hardcoded values.
                _currentPos++;
            }
        }

        return _output;
    }

}