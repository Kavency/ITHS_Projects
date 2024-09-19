// 5.Bil
// Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, 
// pris och färg. Skapa publika properties för att hämta eller ändra värdet på varje field.

// Skriv en konstruktor till bilklassen som inte tar några parametrar. Skriv en till 
// konstruktor som tar en parameter för varje property som klassen har och initierar 
// dessa. Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?

// Skriv en metod till bilklassen med namnet HalfPrice(). När den anropas ska priset 
// på bilen sänkas till hälften.



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


}