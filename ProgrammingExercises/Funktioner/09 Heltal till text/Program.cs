// 9.Heltal till text
// Skriv en funktion som tar en ushort som parameter, 
// och returnerar en sträng med numret utskrivet i ord.

Console.Write("Enter a number: ");
string number = Console.ReadLine();

foreach (string item in IntegerToText(ushort.Parse(number)))
{
    Console.Write(item + " ");
}

string[] IntegerToText(ushort number)
{
    string numberAsString = number.ToString();
    string[] returnArray = new string[numberAsString.Length];

    for (int i = 0; i < numberAsString.Length; i++)
    {

        if (numberAsString[i] == '0')
            returnArray[i] = "Zero";
        else if (numberAsString[i] == '1')
            returnArray[i] = "One";
        else if (numberAsString[i] == '2')
            returnArray[i] = "Two";
        else if (numberAsString[i] == '3')
            returnArray[i] = "Three";
        else if (numberAsString[i] == '4')
            returnArray[i] = "Four";
        else if (numberAsString[i] == '5')
            returnArray[i] = "Five";
        else if (numberAsString[i] == '6')
            returnArray[i] = "Six";
        else if (numberAsString[i] == '7')
            returnArray[i] = "Seven";
        else if (numberAsString[i] == '8')
            returnArray[i] = "Eight";
        else if (numberAsString[i] == '9')
            returnArray[i] = "Nine";
    }

    return returnArray;

}
