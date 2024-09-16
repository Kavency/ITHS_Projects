// 1.Skriva ut namn på personer
// Skriv en klass som representerar en person. Klassen ska ha två publika 
// fält (fields): firstName, lastName. Skapa två instanser av personer med
// olika för och efternamn, och använd sedan dessa för att printa ut (hela) 
// namnen på de olika personerna.

internal class Program
{
    private static void Main(string[] args)
    {
        Person Kalle = new Person() { FirstName = "Kalle", LastName = "Anka"};
        Person Kajsa = new Person() { LastName = "Kajsa", FirstName = "Anka" };
    }
}

class Person
{
    public string FirstName;
    public string LastName;
}