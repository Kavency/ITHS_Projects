// 14.Spel - Gissa tal
// Gör ett gissa-spel som har ett hemligt nummer (lagrat i en variabel i koden) mellan 1 och 100. När spelet startar
// ombeds spelaren att gissa ett tal mellan 1-100. Gissar man för lågt skriver programmet ut att man gissat för lågt,
// och man får gissa igen. Gissar man för högt skriver programmet att man gissat för högt och man får gissa igen. Gissar
// man rätt så skriver programmet att man gissat rätt, samt antal gissningar som krävdes för att gissa rätt.

// Extrauppgift: Klassen “Random” i .NET kan användas för att sätta den hemliga variabeln till ett slumpmässigt 
// tal 1-100. Googla “C# Random” och se om du får det att fungera så det blir olika tal varje gång man kör programmet.

// Extrauppgift 2: Gör så att datorn själv (automatiskt) spelar spelet, och gissar tal. Skriv ut output precis som 
// innan så man kan följa hur den spelat. Försök få den att lösa det så effektivt (så få drag) som möjligt.

namespace _14_Spel___Gissa_tal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new();
            
            bool isPlayerPlaying;
            string userInput;
            int superSecretNumber = randomNumber.Next(101);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till gissa talet");
                Console.WriteLine("--------------------------");
                Console.WriteLine();
                Console.Write("Vill du spela (j/n) (vid n spelar datorn själv. x för att avsluta) ? ");

                userInput = Console.ReadLine().ToLower();

                while (true)
                {
                    if (userInput == "j")
                    {
                        // Run player game mode.
                        break;
                    }
                    else if (userInput == "n")
                    {
                        isPlayerPlaying = false;

                        // Run computer play mode.
                        break;
                    }
                    else if (userInput == "x")
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Ange ett giltigt alternativ (j/n/x): ");
                        userInput = Console.ReadLine().ToLower();
                    }
                }

                if (userInput == "x")
                    break;
            }
        }

        static string userInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
