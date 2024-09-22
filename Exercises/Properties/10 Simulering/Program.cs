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
    } while (cars[i].Colour == ConsoleColor.Black || cars[i].Colour == ConsoleColor.White);
}

while (true)
{
    int carNo = 1;

    Console.Clear();

    Console.WriteLine("---------------------------------------");
    Console.Write("{0,-9}", "| Car no ") ;
    Console.Write("{0,-23}", "| Position on track  |") ;
    Console.WriteLine("{0,-8}", "Speed |") ;
    Console.WriteLine("---------------------------------------");

    foreach (var car in cars)
    {
        car.DriveForOneHour();
        
        // Colours only the X on the track.        
        string[] trackRender = new string[2];
        trackRender = car.GetGraph().Split('X', 2);

        Console.Write("|   {0,-5}", carNo);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(trackRender[0]);
        Console.ForegroundColor = car.Colour;
        Console.Write("X");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(trackRender[1]);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" {0,-3}   |", car.Speed);
        Console.WriteLine("---------------------------------------");

        // Colours the entire track.
        //Console.Write("|   {0,-5}", carNo);
        //Console.ForegroundColor = car.Colour;
        //Console.Write("{0,-23}", car.GetGraph());
        //Console.ForegroundColor = ConsoleColor.Gray;
        //Console.WriteLine(" {0,-3}  |", car.Speed);
        //Console.WriteLine("---------------------------------------");

        carNo++;
    }
    
    Thread.Sleep(1000);
}


class Car
{
    private ConsoleColor _colour;
    private double _length;
    private int _speed;
    private int _distanceDriven = 0;
    private int _currentPos = 1;
    private int _nextCheckpoint = 500;
    private int _noOfCheckpoints = 20;
    private int _totalDistanceToDrive = 10000;
    private string _distanceTracker = "|X-------------------|";

    public ConsoleColor Colour { get { return _colour; } }
    public double Length { get { return _length; } }
    public int Speed { get { return _speed; } }
    public int DistanceDriven { get { return _distanceDriven; } }
    public int TotalDistanceToDrive 
    { set 
        { 
            _totalDistanceToDrive = value;
            _nextCheckpoint = _totalDistanceToDrive / _noOfCheckpoints;
        }
    }

    public Car()
    {
        Random rnd = new();
        _colour = (ConsoleColor)rnd.Next(0, 16);
        _length = rnd.Next(3, 6);
        _speed = rnd.Next(60, 241);
        _nextCheckpoint = _totalDistanceToDrive / _noOfCheckpoints;

    }

    public void DriveForOneHour()
    {
        _distanceDriven += Speed;
    }

    public string GetGraph()
    {
        for (int i = 0; i < 20; i++)
        {
            if(_currentPos > 19)
            {
                _currentPos = 19;
            }

            if (_distanceDriven >= _nextCheckpoint && i > 0)
            {
                _distanceTracker = _distanceTracker.Remove(_currentPos, 2);
                _distanceTracker = _distanceTracker.Insert(_currentPos, "-");
                _distanceTracker = _distanceTracker.Insert(_currentPos + 1, "X");

                _nextCheckpoint += _totalDistanceToDrive / _noOfCheckpoints;
                _currentPos++;
            }
        }

        return _distanceTracker;
    }

}