// 5.Initiera i Vehicle, skriv ut i Car.
// Uppdatera Vehicle-klassen så den sätter slumpmässiga (men rimliga) 
// värden för längd, bredd och höjd.
// Uppdatera Car-klassen så att även längden skrivs ut när samma kod 
// som i uppgift 3 körs.
// Ex: "A white 4.1 meter long Yaris from Toyota".
Car car = new(CarBrands.Toyota, CarColours.White, "Yaris");


Console.WriteLine(new Car(CarBrands.Toyota, CarColours.White, "Yaris"));


Console.ReadLine();


//
// Vehicle class
//
class Vehicle
{
    public CarBrands CarBrand { get; set; }
    public CarColours CarColour { get; set; }

    public CarSize carSize = new();

    public Vehicle()
    {
        CarBrand = CarBrands.Saab;
        CarColour = CarColours.White;
    }
    public Vehicle(CarBrands carBrand)
    {
        CarBrand = carBrand;
        CarColour = CarColours.White;
    }
    public Vehicle(CarBrands carBrand, CarColours carColour)
    {
        Random rnd = new();
        
        CarBrand = carBrand;
        CarColour = carColour;
        carSize.Length = rnd.Next(1, 5);
    }

    public override string ToString()
    {
        return $"A {CarColour} {CarBrand}";
    }
}


//
// Car Class 
//
class Car : Vehicle
{
    public string CarModel { get; set; }

    public Car(CarBrands carBrand, CarColours carColour, string carModel) : base (carBrand, carColour)
    {
        CarModel = carModel;
    }

    public override string ToString()
    {
        return $"A {CarModel} of length {carSize.Length} is a {CarColour} car from {CarBrand}";
    }
}

//
// Enums
//
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

//
// Struct
//
struct CarSize
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public CarSize(int length, int width = 2, int height = 1)
    {
        Length = length;
        Width = width;
        Height = height;
    }
}