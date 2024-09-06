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
string subString = string.Empty;


string stringToCheck = GetUserInput("Enter a string: ");

for (int i = 0; i < stringToCheck.Length; i++)
{
    charToCompare = stringToCheck[i];
    coloredNumbers = string.Empty;

    for (int j = startInnerLoopAt; j < stringToCheck.Length; j++)
    {
        if (char.IsDigit(stringToCheck[j]))
        {
            coloredNumbers += stringToCheck[j];

            if (charToCompare == stringToCheck[j] && coloredNumbers.Length > 1)
            {
                listOfColoredNumbers.Add(coloredNumbers);

                //for (int k = 0; k < coloredNumbers.Length; k++)
                //{
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.Write(coloredNumbers[k]);
                //    Console.ForegroundColor = ConsoleColor.Gray;
                //    continue;
                //}
                subString = stringToCheck.Substring(i, coloredNumbers.Length);
                break;
            }
        }
        else
            break;
    }
    Console.WriteLine(subString);  // Skriver ut dubbelt när den stöter på en bokstav.
    startInnerLoopAt++;
}

foreach (string item in listOfColoredNumbers)
{
    totalSum += long.Parse(item);
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
