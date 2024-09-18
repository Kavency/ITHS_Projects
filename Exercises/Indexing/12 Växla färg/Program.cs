// 12.Växla färg
// Be användaren mata in en text. Be sedan användaren mata in en bokstav. 
// Skriv ut hela texten, rödmarkera från första stället den hittar bokstaven 
// till andra stället den hittar bokstaven, från tredje stället till fjärde o.s.v.

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("Enter a string: ");
string userInput = Console.ReadLine();
Console.Write($"Enter a letter: ");
char userChar = char.Parse(Console.ReadLine());

int isColoured = -1;

for (int i = 0; i < userInput.Length; i++)
{
    if (userInput[i] == userChar)
    {
        isColoured *= -1;
    }
    if(isColoured > 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(userInput[i]);
    }
    else
    {
        Console.Write(userInput[i]);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}