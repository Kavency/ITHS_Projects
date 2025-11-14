// 5.Bil
// Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, 
// pris och färg. Skapa publika properties för att hämta eller ändra värdet på varje field.

// Skriv en konstruktor till bilklassen som inte tar några parametrar. Skriv en till 
// konstruktor som tar en parameter för varje property som klassen har och initierar 
// dessa. Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?

// Skriv en metod till bilklassen med namnet HalfPrice(). När den anropas ska priset 
// på bilen sänkas till hälften.

Car volvo = new();
Car saab = new("95", "Blue", 450.0);


volvo.Model = "245";
volvo.Colour = "Green";
volvo.Price = 230;

Console.WriteLine($"Volvo Model: {volvo.Model} Colour: {volvo.Colour} Price: ${volvo.Price}");
Console.WriteLine($"Saab Model: {saab.Model} Colour: {saab.Colour} Price: ${saab.Price}");

volvo.HalfPrice();
Console.WriteLine($"Volvo 50% off: ${volvo.Price}");

class Car
{
    private string _model;
    private string _colour;
    private double _price;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    public string Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }
    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public Car() { }
    public Car(string model, string colour, double price)
    {
        this.Model = model;
        this.Colour = colour;
        this.Price = price;
    }

    public void HalfPrice()
    {
        this.Price /= 2;
    }
}