// 11.Start & Stop
// Be användaren mata in en text. Be sedan om ett startindex, 
// och sedan om ett stopindex. Skriv ut hela texten, 
// men alla tecken från startindex till stopindex ska vara röda.

int startIndex = 0;
int stopIndex = 0;

Console.Write("Enter a word: ");
string userInput = Console.ReadLine();

Console.Write("Enter a start number: ");
startIndex = Int32.Parse(Console.ReadLine());
Console.Write("Enter a stop number: ");
stopIndex = Int32.Parse(Console.ReadLine());

for(int i = 0; i < userInput.Length; i++)
{
    if(userInput.Length - 1 > i && i >= startIndex - 1 && i <= stopIndex -1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(userInput[i]);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
        Console.Write(userInput[i]);
}