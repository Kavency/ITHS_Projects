// 06 Miniräknare
// Skapa en enkel miniräknare som kan hantera de fyra räknesätten med två operander.
// Till skillnad från uppgift 6 i övningsuppgifter med variabler, så ska inmatningen
// nu ske på en rad (första talet, operator, andra talet). Ignorera inmatade mellanslag
// i strängen. Om man t.ex. matar in strängen "34 - 14", så ska programmet skriva ut "= 20".

string userInput = string.Empty;
string num1Str, num2Str;
double num1, num2;
char opChar = '+';
double result = 0;

while (true)
{
    Console.Clear();
    Console.Write("Vad vill du räkna ut? ");
    userInput = Console.ReadLine();

    opChar = GetOperator(userInput);

    if (userInput.ToLower() == string.Empty || userInput == "x")
        break;
    
    num1Str = userInput.Substring(0, userInput.IndexOf(opChar));
    num2Str = userInput.Substring(userInput.IndexOf(opChar) + 1);
    num1Str = num1Str.Trim();
    num2Str = num2Str.Trim();

    num1 = double.Parse(num1Str);
    num2 = double.Parse(num2Str);

    if (opChar == '+')
        result = num1 + num2;
    else if (opChar == '-')
        result = num1 - num2;
    else if (opChar == '/')
        result = num1 / num2;
    else if (opChar == '*')
        result = num1 * num2;
    
    Console.WriteLine($"{num1Str} {opChar} {num2Str} = {result}");
    Console.WriteLine("Press anykey to continue.");
    Console.ReadKey();
}

char GetOperator(string value)
{
    if (value.Contains('+'))
        return '+';
    else if (value.Contains('-'))
        return '-';
    else if (value.Contains('/'))
        return '/';
    else if (value.Contains('*'))
        return '*';
    else
       return ' ' ;
}