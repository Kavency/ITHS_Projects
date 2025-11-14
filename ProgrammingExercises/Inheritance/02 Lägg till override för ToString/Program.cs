// 2.Lägg till override för ToString()
// ToString() är en metod som alla klasser ärver från System.Object. 
// Denna metod anropas implicit när man skickar in ett objekt till 
// Console.WriteLine, eller använder ett objekt i en konkatenering 
// (t.ex en interpolation string). Implementationen i System.Object 
// är sådan att den bara skriver ut objektets datatyp, men din klass 
// kan göra en override på ToString() och returnera en sträng i vilket 
// format du vill.

Console.WriteLine(new Vehicle(CarBrands.Toyota, CarColours.White));

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