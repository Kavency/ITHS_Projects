// 8.Privat fält, med metoder för att sätta och hämta värdet.
// Uppdatera klassen med ett fält, private double length, som kan lagra längden på personen.
// Eftersom denna är markerad som private kommer man inte kunna läsa/skriva denna utanför klassen.
// Lägg därför till en metod void SetLength(double length) som sätter värdet på det privat fältet length, 
// samt en double GetLength() som returnerar värdet på fältet length.

Person kalle = new Person() { FirstName = "Kalle", LastName = "Anka" };
Person kajsa = new Person() { LastName = "Kajsa", FirstName = "Anka" };

kalle.Mother = new Person() { FirstName = "Lisa", LastName = "Anka" };

Console.WriteLine(kalle.GetSelfAndParents());






class Person
{
    public string FirstName = string.Empty;
    public string LastName = string.Empty;
    
    private double _Height = 0.0D;

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

    public string GetSelfAndParents()
    {
        if (this.Mother == null)
            this.Mother = new Person() { FirstName = "Okänd" };
        if (this.Father == null)
            this.Father = new Person() { FirstName = "Okänd" };

        return $"{this.GetFullName()} - Mor: {this.Mother.GetFullName()} - Far: {this.Father.GetFullName()}";
    }

    public void SetHeight(double height)
    {
        _Height = height;
    }

    public double GetHeight()
    {
        return _Height;
    }

}