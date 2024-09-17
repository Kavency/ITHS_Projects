// 3.Kolla om stängen är längre än ett givet antal tecken.
// Skriv en funktion som tar in en sträng och ett heltal. 
// Om längden på strängen är större än heltalet returnera true, annars false.

Console.Write("Enter a string: ");
string userString = Console.ReadLine();
Console.Write("Enter a number: ");
int  userNumber = Int32.Parse(Console.ReadLine());

CompareLength(userString, userNumber);


void CompareLength(string userString, int userNumber)
{
    if(userString.Length < userNumber)
        Console.WriteLine("The length of the string is smaller than the number.");
    else if(userString.Length > userNumber)
        Console.WriteLine("The length of the string is bigger than the number.");
    else
        Console.WriteLine("The length of the string is equal to the number.");
}