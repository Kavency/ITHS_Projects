// 7.Modifiera utskrift med lambdauttryck
// Skriv en metod som tar en string[] som inparameter och skriver
// ut alla strängar i arrayen på varsin rad. Uppdatera sedan metoden
// så att den tar en andra parameter: Func<string, string> modifier,
// och anropa modifier() på varje string i arrayen innan du skriver ut den.
//
// Skapa en en string[] med namnen på fem städer som du kan skicka in i metoden.
//
// Gör 3 anrop till metoden (med olika lambda-uttryck):
//
// Ett som skriver ut alla städer i UPPERCASE
// Ett som skriver ut de 3 första tecknen i varje stad
// Ett som skriver ut längden på varje stads namn.

string[] cities = { "Göteborg", "Stockholm", "Malmö", "Karlstad", "Umeå" };

PrintStrings(cities, x => x.ToUpper());
PrintStrings(cities, x => x.Substring(0, 3));
PrintStrings(cities, x => x.Length.ToString());

void PrintStrings(string[] strings, Func<string, string> modifier)
{
    foreach(string item in strings)
    {
        Console.WriteLine(modifier(item));
    }
}