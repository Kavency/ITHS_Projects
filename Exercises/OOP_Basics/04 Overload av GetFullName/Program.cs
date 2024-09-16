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