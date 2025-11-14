// 4.Skapa en struct för att spara längd, bredd och höjd.
// Skapa en struct Size med properties Length, Width och Height; 
// samt en konstruktor som tar 3 argument för att initiera dessa.


//
// Stuff below.
//

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