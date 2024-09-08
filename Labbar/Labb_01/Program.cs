using System.Xml.Linq;

Console.Clear();
Console.WriteLine("********* Labb 01 *********");
Console.WriteLine("* .NET24 - Magnus Hellman *");
Console.WriteLine("***************************");
Console.WriteLine();
Console.WriteLine();

List<string> listOfColoredNumbers = new();
List<string> listOfSubStrings = new();

long totalSum = 0;
int startInnerLoopAt = 0;
char charToCompare = ' ';
string coloredNumbers = string.Empty;


string userInput = GetUserInput("Enter a string: ");

for (int i = 0; i < userInput.Length; i++)
{
    charToCompare = userInput[i];
    coloredNumbers = string.Empty;

    for (int j = startInnerLoopAt; j < userInput.Length; j++)
    {
        if (char.IsDigit(userInput[j]))
        {
            coloredNumbers += userInput[j];

            if (charToCompare == userInput[j] && coloredNumbers.Length > 1)
            {
                listOfColoredNumbers.Add(coloredNumbers);
                break;
            }
        }
        else
            break;
    }
    startInnerLoopAt++;
}

foreach (string item in listOfColoredNumbers)
{
    totalSum += long.Parse(item);

    string[] tmp = userInput.Split(item);

    Console.Write(tmp[0]);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(item);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(tmp[1]);
    Console.WriteLine();
}

// Todo: OM listOfColoredNumbers är tom. Skriv ut stringToCheck en gång i grått.


Console.WriteLine();
Console.WriteLine($"Den totala summan är: {totalSum}");
Console.ReadKey();


static string GetUserInput(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();

    if (input == string.Empty)
        return "29535123p48723487597645723645";

    return input;
}
