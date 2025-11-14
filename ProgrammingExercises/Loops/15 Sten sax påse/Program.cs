// 15.Sten, sax, påse
// Skriv ett sten-sax-påse spel. Användaren skriver in “sten”, “sax” eller “påse”.
// Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omgången.
// Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något). 
// Skriv även ut poäng.

Random slumpGenerator = new Random();

string userChoice = string.Empty;
string cpuChoice = string.Empty;
int userScore = 0;
int cpuScore = 0;
int counter = 0;
int randomNum = slumpGenerator.Next(1, 4);

while (counter < 5)
{
    Console.Clear();
    Console.WriteLine("Välj (1)Sten (2)Sax (3)Påse: ");
    userChoice = Console.ReadLine();
    if (userChoice == "")
        break;

    userChoice = AssignChoices(Int32.Parse(userChoice));
    cpuChoice = AssignChoices(slumpGenerator.Next(1, 4));

    Console.WriteLine(userChoice);
    Console.WriteLine(cpuChoice);
    
    if (userChoice == cpuChoice)
    {
        Console.WriteLine("oavgjort");
    }
    else if (userChoice == "Sten" && cpuChoice == "Sax"
        || userChoice == "Sax" && cpuChoice == "Påse"
        || userChoice == "Påse" && cpuChoice == "Sten")
    {
        Console.WriteLine("Player wins.");
        userScore++;
    }
    else
    {
        Console.WriteLine("CPU wins");
        cpuScore++;
    }
    counter++;
    Thread.Sleep(1000);
}

Console.Clear();
if(cpuScore > userScore)
    Console.WriteLine("You are a big looooser!");
else
    Console.WriteLine("Peew... some lucky one!");
Console.WriteLine();
Console.WriteLine("Scores:");
Console.WriteLine($"Player: {userScore}");
Console.WriteLine($"CPU: {cpuScore}");


string AssignChoices(int number)
{
    switch (number)
    {
        case 1:
            return "Sten";
        case 2:
            return "Sax";
        case 3:
            return "Påse";
        default:
            return "";
    }
}

