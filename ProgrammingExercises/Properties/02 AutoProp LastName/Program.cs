// 2.Autoproperty LastName
// Lägg till en publik auto-property LastName som går att både läsa och skriva.

Person someDude = new();

someDude.FirstName = "John";
someDude.LastName = "Lebowsky";

Console.WriteLine($"{someDude.FirstName} {someDude.LastName}");


class Person
{
    private string _firstName;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName { get; set; }

}