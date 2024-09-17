// 4.Dölj vokaler
// Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

string vowelString = "aeiouyåäö";

Console.Write("Enter any text: ");
string userInput = Console.ReadLine();

Console.WriteLine();

for (int i = 0; i < userInput.Length; i++)
{
    if (vowelString.Contains(userInput[i]))
        Console.Write('*');
    else
        Console.Write(userInput[i]);
}
