// 3.Metod som tar delegat som inparameter
// Skriv en ny metod som också tar firstName och lastName. Denna metoden ska
// returnera en sträng som innehåller variabelnamnen och dess värden på två rader.
//
// Skriv sedan en metod som tar ett generiskt delegat (som matchar metoden ovan) 
// som inparameter. Metoden ska, i tur och ordning, anropa delegatet med 3 olika
// för- och efternamn och skriva ut resultatet. Testa att anropa denna metod först
// med en referens till metoden som i uppgift 1 och sedan med metoden ovan (uppgift 3).

Func<string, string, string> CallNames;
CallNames = GetName;

Console.WriteLine(CallNames("First", "Call"));

CallDelegate(CallNames);


void CallDelegate(Func<string, string, string> nameCaller)
{
    Console.WriteLine(CallNames("John", "Doe"));
    Console.WriteLine(CallNames("Jane", "Doe"));
    Console.WriteLine(CallNames("Some Other", "Doe"));
    //Console.WriteLine(nameCaller);
}

string GetName(string firstName, string lastName)
{
    return $"{firstName}\r\n -{lastName}";
}