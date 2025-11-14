// 4.Stegräknare
// Skapa en klass som kan användas som stegräknare. Den ska ha en property "Steps" som bara 
// går att läsa; en metod Step() som räknar upp Steps med 1 varje gång man anropar den; och 
// en metod Reset() som nollställer räknaren.

// Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. 
// Skriv ut värdet på Steps.

StepCounter stepCounter = new();

for (int i = 0; i < 1000; i++)
{
    Console.Clear();
    stepCounter.Step();

    Console.WriteLine(stepCounter.Steps);
    Thread.Sleep(2);
}

stepCounter.Reset();

class StepCounter
{
    private int _steps;

    public int Steps { get { return _steps; } }

    public void Step()
    {
        _steps++;
    }

    public void Reset()
    {
        _steps = 0;
    }
}