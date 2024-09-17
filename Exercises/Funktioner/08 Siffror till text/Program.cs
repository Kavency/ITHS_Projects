// 8.Siffror till text
// Skriv en funktion som tar ett heltal in, och returnerar en string[] där 
// varje element innehåller ordet för varje siffra i talet.

Console.Write("Enter a number: ");
int number = Int32.Parse(Console.ReadLine());

foreach (string item in NumbersToText(number))
{
    Console.Write(item + " ");
}

string[] NumbersToText(int number)
{
    string numberAsString = number.ToString();
    string[] returnArray = new string[numberAsString.Length];

	for(int i = 0; i < numberAsString.Length; i++)
    {

        if (numberAsString[i] == '0')
            returnArray[i] = "Zero";
        else if(numberAsString[i] == '1')
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