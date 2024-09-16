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