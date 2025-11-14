// 3.Baklänges
// Be användaren mata in en text. Skriv sedan ut texten baklänges.

Console.Write("Enter any text: ");
string userInput = Console.ReadLine();

for(int i = userInput.Length - 1; i >= 0; i--)
{
    Console.Write(userInput[i]);
}