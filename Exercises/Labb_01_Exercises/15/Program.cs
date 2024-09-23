// 15.Rödmarkerade bokstäver 3
// Användaren matar in valfri sträng. Programmet skriver sedan ut en hela strängen flera gånger.
// På första raden börjar den skriva med röd färg på första bokstaven och fram tills den
// hittar samma bokstav igen. På andra raden börjar den skriva med röd färg på andra bokstaven
// och fram tills den hittar samma bokstav igen. På tredje raden börjar den skriva med röd text
// på tredje bokstaven och fram tills den hittar samma igen... etc.

string userInput = string.Empty;
int nextCharIndex = 0;

Console.Write("Enter a string: ");
userInput = Console.ReadLine();

for (int i = 0; i < userInput.Length; i++)
{
    nextCharIndex = userInput.IndexOf(userInput[i], i + 1);

    for (int j = 0; j < userInput.Length && nextCharIndex >= 0; j++)
    {
        if (j < nextCharIndex + 1 && j > i - 1)
            Console.ForegroundColor = ConsoleColor.Red;

        else
            Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write(userInput[j]);
    }

    if (nextCharIndex < 0)
        continue;

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine();
}
