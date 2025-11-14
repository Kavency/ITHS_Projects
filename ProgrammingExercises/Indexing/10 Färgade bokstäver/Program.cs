// 10.Färgade bokstäver
// Man kan byta färg som används för utskrift i console med hjälp av
// Console.ForegroundColor (t.ex Console.ForegroundColor = ConsoleColor.Red)
// Skapa ett program som ber användaren mata in en text. Be sedan användaren mata in en bokstav.
// Skriv ut strängen som matades in; de bokstäver som är samma som den användaren valde ska
// skriva ut med röd färg, alla andra med grå..

Console.Write("Enter a word: ");
string userInput = Console.ReadLine();
Console.Write($"Enter a letter in {userInput}: ");
char userChar = char.Parse(Console.ReadLine());

for (int i = 0; i < userInput.Length; i++)
{
	if (userInput[i] == userChar)
	{
		Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(userInput[i]);
        Console.ForegroundColor = ConsoleColor.Gray;
	}
	else
		Console.Write(userInput[i]);
}