namespace SingletonPattern;

public class Logger : ILogger
{
    public void Log(string msg)
    {
        var dateTime = DateTime.Now;
        Console.WriteLine($"[LOG] {dateTime}: {msg}");
    }
}