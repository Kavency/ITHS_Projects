// 2.Använd generiskt delegat
// Ändra koden i uppgift 01 så att den använder ett generiskt
// delegat istället för den du själv deklarerade.

Func<string, string, string> fullName;

fullName = GetFullName;

Console.WriteLine(fullName("John", "Doe"));

string GetFullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}
