// 7.Blå & Röd
// Skapa en en klass som har en property “Red” och en property “Blue”. 
// Båda ska vara en double och kunna ha ett värde mellan 0.0 och 100.0 
// men de ska vara “sammankopplade” på så vis att värdena tillsammans 
// alltid är 100.0 d.v.s om man t.ex. sätter “Blue” till 8.5 och sedan 
// läser av “Red” så ska den returnera 91.5.

ColourConnection colours = new();

colours.PrintValues();
Console.WriteLine();

colours.Blue = 25;

colours.PrintValues();
Console.WriteLine();

colours.Red = 65.5;

colours.PrintValues();
Console.WriteLine();


class ColourConnection
{
    private double _blue = 50;
    private double _red = 50;
    private double _maxValue = 100;

    public double Blue { set { _blue = value; _red = _maxValue - value; } }
    public double Red { set { _red = value; _blue = _maxValue - value; } }
    
    public void PrintValues()
    {
        Console.WriteLine($"Blue is: {_blue}");
        Console.WriteLine($"Red is:  {_red}");
    }
}