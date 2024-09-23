// 4.Bokstav för bokstav - gröna o, röda l
// Utgå från strängen "Hello world!". Skriv ut bokstav 
// för bokstav. Alla 'o' ska vara grön färg, alla 'l' 
// ska vara röd färg. Övriga bokstäver är vita/grå.

string text = "Hello, World!";

foreach (char item in text)
{
    Console.ResetColor();

    if (item.ToString().ToLower() == "o")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(item);
    }
    else if (item.ToString().ToLower() == "l")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(item);
    }
    else
        Console.Write(item);
}

Console.ReadKey();
