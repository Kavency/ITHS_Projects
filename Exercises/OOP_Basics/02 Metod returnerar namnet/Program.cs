// 2.Lägg till en metod som returnerar hela namnet
// Uppdatera klassen i uppgift 1 med en metod: 
// public string GetFullName(), som returnerar en 
// sträng med hela namnet.

Person kalle = new Person() { FirstName = "Kalle", LastName = "Anka" };
Person kajsa = new Person() { LastName = "Kajsa", FirstName = "Anka" };

Console.WriteLine(kalle.GetFullName());
Console.WriteLine(kajsa.GetFullName());

class Person
{
    public string FirstName;
    public string LastName;

    public string GetFullName()
    {
        return $"{this.FirstName} {this.LastName}";
    }
}