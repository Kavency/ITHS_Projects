// 2.Multiplicera två tal
// Skriv ett program som ber användaren mata in två heltal. Skriv ut talen multiplicerade 
// med varandra.

string userInput;
int firstNumber;
int secondNumber;

userInput = GetUserInput("Ange första talet");

while (!Int32.TryParse(userInput, out firstNumber))
{
    userInput = GetUserInput("Vänligen ange ett heltal");
}

userInput = GetUserInput("Ange andra talet");

while (!Int32.TryParse(userInput, out secondNumber))
{
    userInput = GetUserInput("Vänligen ange ett heltal");
}

Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");


static string GetUserInput(string prompt)
{
    Console.Write(prompt + " > ");
    return Console.ReadLine();
}
