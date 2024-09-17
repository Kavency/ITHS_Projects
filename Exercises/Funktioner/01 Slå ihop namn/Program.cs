// 1.Slå ihop för- och efternamn - skriv ut
// Skriv en funktion som tar två parametrar: firstName och lastName. 
// Funktionen ska skriva ut hela namnet på skärmen. 
// Testa genom att anropa funktionen med ditt namn.

Console.Write("Enter your first name: ");
string firstName = Console.ReadLine();
Console.Write("Enter your last name: ");
string lastName = Console.ReadLine();


CombineNames(firstName, lastName);


void CombineNames(string firstName, string lastName)
{
    Console.WriteLine($"{firstName} {lastName}");
}