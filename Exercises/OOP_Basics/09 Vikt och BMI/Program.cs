// 9.Vikt och BMI
// Gör motsvarande för Vikt, alltså ett privat fält med publika metoder: double GetWeight()
// och void SetWeight(double weight). Gör sedan även en publik metod double GetBMI()
// som returnerar personens BMI. Detta ska dock inte finnas representerat som en private field.

Person kalle = new Person() { FirstName = "Kalle", LastName = "Anka" };
Person kajsa = new Person() { LastName = "Kajsa", FirstName = "Anka" };

kalle.Mother = new Person() { FirstName = "Lisa", LastName = "Anka" };

Console.WriteLine(kalle.GetSelfAndParents());
kalle.SetHeight(1.27);
Console.WriteLine(kalle.GetHeight());





class Person
{
    public string FirstName = string.Empty;
    public string LastName = string.Empty;

    private double _Height = 0.0D;
    private double _Weight = 0.0D;

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
        this._Height = height;
    }

    public double GetHeight()
    {
        return _Height;
    }

    public void SetWeight(double weight)
    {
        this._Weight = weight;
    }

    public double GetWeight()
    {
        return _Weight;
    }

    public double GetBMI()
    {
        // Add BMI math.
        return 0.0D;
    }
}