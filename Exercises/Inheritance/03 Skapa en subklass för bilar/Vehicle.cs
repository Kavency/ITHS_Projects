// 3.Skapa en subklass för bilar
// Skapa en klass Car som ärver av Vehicle. Lägg till en 
// publik property Model, och skapa en konstruktor som 
// initierar Brand, Model och Color.

class Vehicle
{
    public CarBrands CarBrand { get; set; }
    public CarColours CarColour { get; set; }

    public Vehicle(CarBrands carBrand)
    {
        CarBrand = carBrand;
        CarColour = CarColours.White;
    }
    public Vehicle(CarBrands carBrand, CarColours carColour)
    {
        CarBrand = carBrand;
        CarColour = carColour;
    }

    public override string ToString()
    {
        return $"A {CarColour} {CarBrand}";
    }
}