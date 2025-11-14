// 7.Hämta information om dig och dina föräldrar.
// Lägg till en public string GetSelfAndParents() som returnerar en sträng
// på formatet "Ditt Namn - Mamma: Mammans Namn - Pappa: Pappans namn".
// Om mammans eller pappans namn saknas (null) markera det med "okänd" i 
// strängen. Exempel: "Fredrik Johansson - Mamma: okänd - Pappa: Göran Johansson"

Person kalle = new Person() { FirstName = "Kalle", LastName = "Anka" };
Person kajsa = new Person() { LastName = "Kajsa", FirstName = "Anka" };

//kalle.Mother = new Person() { FirstName = "Lisa", LastName = "Anka" };

Console.WriteLine(kalle.GetSelfAndParents());

class Person
{
    public string FirstName = string.Empty;
    public string LastName = string.Empty;

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

}