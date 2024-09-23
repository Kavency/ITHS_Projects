// 3.Bokstav för bokstav - varannan stjärna
// Utgå från strängen "Detta är uppgift 3". Skriv ut bokstav för 
// bokstav. Men om index är en jämn siffra, skriv istället ut *

string text = "Hello world";

for (int i = 0; i < text.Length; i++)
{
    if (i % 2 == 0)
        Console.Write("*");
    else
        Console.Write(text[i]);
}

Console.ReadKey();
