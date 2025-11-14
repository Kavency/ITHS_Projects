// 3.Skapa en subklass för bilar
// Skapa en klass Car som ärver av Vehicle. Lägg till en 
// publik property Model, och skapa en konstruktor som 
// initierar Brand, Model och Color.

Console.WriteLine(new Car(CarBrands.Toyota, CarColours.White, "Yaris"));




class Vehicle
{
    public CarBrands CarBrand { get; set; }
    public CarColours CarColour { get; set; }

    public Vehicle() { }
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

class Car : Vehicle
{
    public string CarModel { get; set; }

    public Car(CarBrands carBrand, CarColours carColour, string carModel)
    {
        CarBrand = carBrand;
        CarColour = carColour;
        CarModel = carModel;
    }

    public override string ToString()
    {
        return $"A {CarColour} {CarModel} from {CarBrand}";
    }
}

enum CarBrands
{
    Volvo,
    Saab,
    Toyota,
    Kia,
    Volkswagen
}
enum CarColours
{
    Blue,
    White,
    Red,
    Green,
    Gray
}

