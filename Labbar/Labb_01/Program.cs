Console.Clear();
Console.WriteLine("********* Labb 01 *********");
Console.WriteLine("* .NET24 - Magnus Hellman *");
Console.WriteLine("***************************");
Console.WriteLine();
Console.WriteLine();

List<string> listOfSubstrings = new();
List<long> listOfNumbers = new();

long totalSum = 0;
int startInnerLoopAt = 0;

char charToCompare = ' ';

string tempString = string.Empty;
string stringToCheck = GetUserInput("Enter a string: ");

for (int i = 0; i < stringToCheck.Length; i++)
{
    charToCompare = stringToCheck[i];
    tempString = string.Empty;

    for (int j = startInnerLoopAt; j < stringToCheck.Length; j++)
    {

        if (char.IsDigit(stringToCheck[j]))
        {
            tempString += stringToCheck[j];

            if (charToCompare == stringToCheck[j] && tempString.Length > 1)
            {
                listOfSubstrings.Add(tempString);
                //listOfNumbers.Add(long.Parse(tempString));
                break;
            }
        }
        else
            break;
    }

    startInnerLoopAt++;
}

foreach (var item in listOfSubstrings)
{
    totalSum += long.Parse(item);
}

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