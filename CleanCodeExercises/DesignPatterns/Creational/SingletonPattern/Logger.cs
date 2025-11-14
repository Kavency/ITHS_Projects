namespace SingletonPattern;

public class Logger : ILogger
{
    public void Log(string msg) => Console.WriteLine($"[LOG] {DateTime.Now}: {msg}");
}