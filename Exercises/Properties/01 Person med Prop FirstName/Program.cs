// 1.Person med property FirstName
// Skapa en klass "Person" som har en private field _firstName, och en public property FirstName.
// När man sätter värdet på FirstName ska detta sparas i _firstName, och när man läser värdet på 
// FirstName ska den returnera det som finns lagrat i _firstName.

Person someDude = new();

someDude.FirstName = "Lebowky";

Console.WriteLine(someDude.FirstName);


class Person 
{
    private string _firstName;

	public string FirstName
	{
		get { return _firstName; }
		set { _firstName = value; }
	}

}
