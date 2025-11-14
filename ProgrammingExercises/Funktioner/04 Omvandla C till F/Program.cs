// 4.Omvandla Celsius till Fahrenheit
// Skriv en funktion som översätter ett värde från Celsius till Fahrenheit.
// Både in-parameter och returvärde ska vara av datatyp double.

Console.WriteLine(ConvertCelsiusToFahrenheit(25));

double ConvertCelsiusToFahrenheit(double degree)
{
    return degree * 9/5 + 32;
}