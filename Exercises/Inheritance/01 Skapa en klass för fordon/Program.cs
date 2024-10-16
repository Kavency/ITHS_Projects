﻿// 1.Skapa en klass för fordon
// Skapa en enum Brand med 5 bilmärken, och en enum Color med 5 färger.
// Skriv sedan en klass Vehicle som har publika properties Brand och 
// Color. Klassen ska ha en konstruktor som man kan använda för att 
// sätta Brand och Color, och en konstruktor som endast tar Brand och 
// sätter en default färg.

namespace _01_Skapa_en_klass_för_fordon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new(CarBrands.Saab);
            Vehicle car2 = new(CarBrands.Volvo, CarColours.Green);

            Console.WriteLine($"{car1.CarBrand} {car1.CarColour}");
            Console.WriteLine($"{car2.CarBrand} {car2.CarColour}");
        }
    }
}
