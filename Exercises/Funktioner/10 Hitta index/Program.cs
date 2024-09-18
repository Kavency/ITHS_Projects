// 10.Hitta index för alla förekomster av ett givet tecken.
// Skapa funktionen int[] IndexesOf(string text, char c) som söker igenom strängen 
// text och returnerar en int[] med index till alla förekomster av c i text.

int[] newArray = IndexOf("assa brassa mandelmassa", 'a'); ;

foreach (var item in newArray)
{
    Console.WriteLine(item);
}

int[] IndexOf(string stringToCheck, char charToCheckFor)
{
    int numberOfOccurences = 0;
    int arrayPosition = 0;

    for (int i = 0; i < stringToCheck.Length; i++)
    {
        if (stringToCheck[i] == charToCheckFor)
        {
            numberOfOccurences++;
        }
    }

    int[] returnArray = new int[numberOfOccurences];

    for (int i = 0; i < stringToCheck.Length; i++)
    {
        if (stringToCheck[i] == charToCheckFor)
        {
            returnArray[arrayPosition] = i;
            arrayPosition++;
        }
    }

    return returnArray;
}