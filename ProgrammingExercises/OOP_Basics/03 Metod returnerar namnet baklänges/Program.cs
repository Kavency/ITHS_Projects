// 3.Lägg till en metod som returnerar namnet baklänges
// Uppdatera klassen med en ny metod: public string GetFullNameReversed() som 
// returnerar en sträng med hela namnet baklänges. Låt denna metoden använda
// sig av metoden i uppgift 2.

Person kalle = new Person() { FirstName = "Kalle", LastName = "Anka" };
Person kajsa = new Person() { LastName = "Kajsa", FirstName = "Anka" };

Console.WriteLine(kalle.ReturnFullNameReversed());

class Person
{
    public string FirstName;
    public string LastName;

    public string GetFullName()
    {
        return $"{this.FirstName} {this.LastName}";
    }

    public string ReturnFullNameReversed()
    {
        string fullName = GetFullName();
        string fullNameReversed = string.Empty;

        for (int i = fullName.Length - 1; i >= 0; i--)
        {
            fullNameReversed += fullName[i];
        }

        return fullNameReversed;
    }

}