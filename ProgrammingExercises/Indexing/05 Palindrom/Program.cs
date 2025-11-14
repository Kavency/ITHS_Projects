// 5.Palindrom
// Ett palindrom är ett ord som blir samma framlänges som baklänges.
// Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.

Console.Write("Enter a word: ");
string userInput = Console.ReadLine();
string palindrom = string.Empty;

for(int i = userInput.Length - 1; i >= 0; i--)
{
    palindrom += userInput[i];
}

if(userInput.ToLower() == palindrom.ToLower())
    Console.WriteLine($"{userInput} är ett palindrom.");
else
    Console.WriteLine($"{userInput} är inte ett palindrom.");