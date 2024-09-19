// 3.Read - only property FullName
// Lägg sedan till en publik property FullName som är read only (bara get;)
// När man läser av propertyn så ska den returnera hela namnet. Testa koden
// genom att skapa ett objekt, tilldela värden på både FirstName och LastName, 
// och sedan skriva ut FullName.

Person someDude = new();

someDude.FirstName = "John";
someDude.LastName = "Lebowsky";

Console.WriteLine($"{someDude.FullName}");


class Person
{
    private string _firstName;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName { get; set; }

    public string FullName { get { return $"{FirstName} {LastName}"; } }
}