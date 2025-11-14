namespace SingletonPattern;

public sealed class SingletonLogger
{
    private static readonly SingletonLogger _instance = new();
    public static SingletonLogger GetInstance =>_instance;

    private SingletonLogger() { }

    public void Log(string msg) => Console.WriteLine($"[LOG] {DateTime.Now}: {msg}");
}
