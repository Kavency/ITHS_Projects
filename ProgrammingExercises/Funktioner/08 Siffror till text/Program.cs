// 8.Siffror till text
// Skriv en funktion som tar ett heltal in, och returnerar en string[] där 
// varje element innehåller ordet för varje siffra i talet.

Console.Write("Enter a number: ");
string number = Console.ReadLine();

foreach (string item in NumbersToText(number))
{
    Console.Write(item + " ");
}

string[] NumbersToText(string number)
{
    string[] returnArray = new string[number.Length];

	for(int i = 0; i < number.Length; i++)
    {

        if (number[i] == '0')
            returnArray[i] = "Zero";
        else if(number[i] == '1')
            returnArray[i] = "One";
        else if (number[i] == '2')
            returnArray[i] = "Two";
        else if (number[i] == '3')
            returnArray[i] = "Three";
        else if (number[i] == '4')
            returnArray[i] = "Four";
        else if (number[i] == '5')
            returnArray[i] = "Five";
        else if (number[i] == '6')
            returnArray[i] = "Six";
        else if (number[i] == '7')
            returnArray[i] = "Seven";
        else if (number[i] == '8')
            returnArray[i] = "Eight";
        else if (number[i] == '9')
            returnArray[i] = "Nine";
    }

    return returnArray;
    
}