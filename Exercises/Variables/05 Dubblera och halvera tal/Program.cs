// 5.Dubblera och halvera tal
// Be användaren mata in ett tal. Skriv ut talet som är dubbelt, 
// respektive hälften.


while (true)
{
    Console.Write("Ange ett tal: ");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "x")
        break;

    if (!double.TryParse(userInput, out double result))
        continue;

    Console.WriteLine($"{result * 2} är dubbelt så mycket som {result}");
    Console.WriteLine($"{result / 2} är hälften så mycket som {result}");
}
