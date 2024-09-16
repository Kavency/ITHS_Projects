// 5.Lägg till så personer kan ha föräldrar.
// Uppdatera person-klassen så att varje person kan ha en mamma och en pappa.
// Dessa representeras som publika fält(fields) av typen Person (eller vad du
// kallade klassen i uppgift 1).

// 4.Overload av GetFullName med titel.
// GetFullName ska finnas i två versioner: en utan parametrar som i uppgift 2; 
// och en där man kan skicka in en titel, t.ex. "Dr." eller "Mr." 
// som returnerar namnet på personen med titeln framför.

Person kalle = new Person() { FirstName = "Kalle", LastName = "Anka" };
Person kajsa = new Person() { LastName = "Kajsa", FirstName = "Anka" };

Console.WriteLine(kalle.ReturnFullNameReversed());

class Person
{
    public string FirstName;
    public string LastName;

    public Person Mother;
    public Person Father;

    public string GetFullName()
    {
        return $"{this.FirstName} {this.LastName}";
    }

    public string GetFullName(string titel)
    {
        return $"{titel} {this.FirstName} {this.LastName}";
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
