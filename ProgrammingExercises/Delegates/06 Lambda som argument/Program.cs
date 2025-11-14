// 6.Lambda som argument
// Anropa metoden (den som tar ett generiskt delegat) i uppgift 3. 
// Som argument skriver du ett lambdauttryck som returnerar en 
// string med antal tecken i namnen: 
// Ex. "firstName has 7 letters, lastName has 9 letters."

Func<string, string, string> CallNames;

//CallNames = GetName;
CallNames = (x, y) => $"Firstname is {x.Length} characters long and the lastname is {y.Length} long.";

CallDelegate(CallNames);

void CallDelegate(Func<string, string, string> nameCaller)
{
    Console.WriteLine(nameCaller("John", "Doe"));
    Console.WriteLine(nameCaller("Jane", "Doe"));
    Console.WriteLine(nameCaller("Some Other", "Doe"));
}
