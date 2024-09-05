Console.WriteLine("********* Labb 01 *********");
Console.WriteLine("* .NET24 - Magnus Hellman *");
Console.WriteLine("***************************");
Console.WriteLine();
Console.WriteLine();

List<string> listOfSubstrings = new();

long totalSum = 0;

string stringToCheck = GetUserInput("Enter a string: ");



static string GetUserInput(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();

    if (input == string.Empty)
        return "29535123p48723487597645723645";

    return input;
}