// 1.Deklarera en egen delegat-typ
// Skriv en metod som tar två strängar: firstName och lastName.
// Metoden ska returnera en ny sträng som är hela namnet. Deklarera 
// en delegat-typ, och gör en variabel som är en referens till 
// metoden. Anropa metoden via delegatet.


// 03 - Instantiate the delegate with a method with the same signature, no paranthesis. This
//      is not a method call.
FullName personsFullName = GetFullName;


// 04 - Call the delegate.
Console.WriteLine(personsFullName("John", "Doe"));


// 02 - Method with a signature that can be used by the delegate.
string GetFullName(string firstName, string lastName) 
{
    return $"{firstName} {lastName}";
}


// 01 - Declare a delegate with a specific method signature.
public delegate string FullName(string firstName, string lastName);
