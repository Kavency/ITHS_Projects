// 5.Lägg in bindesträck mellan tecken i en sträng
// Skriv en funktion som tar in en sträng och returnerar en sträng med ett
// bindestreck mellan varje tecken. T.ex om man skickar in “Fredrik” , 
// så returnerar den “F-r-e-d-r-i-k”

Console.Write("Enter a string: ");
string userString = Console.ReadLine();

Console.WriteLine(HiphonsInString(userString));


string HiphonsInString(string value)
{
    string returnString = string.Empty;
    int length = 1;

    foreach(char character in value)
    {
        if(length == value.Length)
        {
            returnString += character;
            break;
        }
        
        returnString += character + "-";
        length++;
    }

    return returnString;
}