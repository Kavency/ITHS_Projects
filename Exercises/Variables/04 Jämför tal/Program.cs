// 4.Jämför tal
// Skriv ett program som frågar användaren efter ett tal. Det ska 
// skriva ut om talet är mindre, större eller lika med 100.


while (true)
{
    int compareToValue = 100;

    Console.Write("Ange ett tal (x för att avsluta): ");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "x")
        break;

    if (!Int32.TryParse(userInput, out int result))
        continue;

    if (result > compareToValue)
        Console.WriteLine($"Talet är större än {compareToValue}!");
    else if (result < compareToValue)
        Console.WriteLine($"Talet är mindre än {compareToValue}!");
    else
        Console.WriteLine($"Talet är exakt {compareToValue}!");
}
