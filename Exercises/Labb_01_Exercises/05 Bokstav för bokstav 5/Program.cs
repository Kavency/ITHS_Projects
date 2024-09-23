// 5.Bokstav för bokstav - dubbla med grön färg
// Utgå från strängen "Hello world". Skriv ut bokstav för bokstav. 
// Om två tecken på rad är samma så ska dessa vara grön färg. 
// Övriga bokstäver är vita/grå.

string text = "Hello Woooorld!";

for (int i = 0; i < text.Length; i++)
{
    if (i > 0 && text[i] == text[i - 1])  // Kontrollera bokstaven innan index.
        Console.ForegroundColor = ConsoleColor.Green;

    else if (i != text.Length - 1 && text[i] == text[i + 1]) // Kontrollera bokstaven efter index.
        Console.ForegroundColor = ConsoleColor.Green;

    else
        Console.ForegroundColor = ConsoleColor.Gray;

    Console.Write(text[i]);

    Console.ForegroundColor = ConsoleColor.Gray;
}
