// 2.Slå ihop för- och efternamn - returnera
// Skriv om funktionen ovan så att den istället för att skriva ut namnet returnerar 
// en string med hela namnet. Anropa funktionen och skriv ut returvärdet.

Console.Write("Enter your first name: ");
string firstName = Console.ReadLine();
Console.Write("Enter your last name: ");
string lastName = Console.ReadLine();


Console.WriteLine(CombineNames(firstName, lastName));


string CombineNames(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}