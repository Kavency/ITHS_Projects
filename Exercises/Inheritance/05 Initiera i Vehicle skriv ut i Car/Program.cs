// 5.Initiera i Vehicle, skriv ut i Car.
// Uppdatera Vehicle-klassen så den sätter slumpmässiga (men rimliga) 
// värden för längd, bredd och höjd.
// Uppdatera Car-klassen så att även längden skrivs ut när samma kod 
// som i uppgift 3 körs.
// Ex: "A white 4.1 meter long Yaris from Toyota".








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

struct CarSize
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public CarSize(int length, int width, int height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
}