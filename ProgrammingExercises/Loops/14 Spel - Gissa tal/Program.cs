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
        static Random randomNumber = new();
        static bool isRestarting = false;
        static bool isExiting = false;
        static string userInput;
        static int superSecretNumber = randomNumber.Next(1, 101);
        static int userGuess;
        static int computerGuess;
        static int numberOfGuesses = 0;
        
        
        
        static void Main(string[] args)
        {
            

            while (isExiting == false)
            {
                isRestarting = false;
                superSecretNumber = randomNumber.Next(1, 101);
                computerGuess = 50;
                numberOfGuesses = 0;

                Console.Clear();
                Console.WriteLine("Välkommen till gissa talet");
                Console.WriteLine("--------------------------");
                Console.WriteLine();
                
                userInput = GetUserInput("Vill du spela (j/n)?\nVid n spelar datorn själv.\nTryck x för att avsluta.\nGör ditt val > ");

                while (isRestarting == false)
                {
                    if (userInput == "j")
                    {
                        while (Int32.TryParse(GetUserInput("Gissa på ett tal från 1 till 100: "), out userGuess))
                        {
                            if (userGuess == superSecretNumber)
                            {
                                numberOfGuesses++;
                                Console.WriteLine($"Du GISSADE RÄTT! Antal gissningar: {numberOfGuesses}");
                                GetUserInput("Tryck enter för att spela igen.");
                                isRestarting = true;
                                break;
                            }
                            else if (userGuess < superSecretNumber)
                            {
                                Console.WriteLine("Du gissadde för lågt. Försök igen.");
                                numberOfGuesses++;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Du gissadde för högt. Försök igen.");
                                numberOfGuesses++;
                                continue;
                            }
                        }
                        
                        break;
                    }
                    else if (userInput == "n")
                    {
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Computer guesses {computerGuess}.");

                            if (computerGuess == superSecretNumber)
                            {
                                numberOfGuesses++;
                                Console.WriteLine($"DATORN GISSADE RÄTT! Antal gissningar: {numberOfGuesses}");
                                GetUserInput("Tryck enter för att spela igen.");
                                isRestarting = true;
                                break;
                            }
                            else if (computerGuess < superSecretNumber)
                            {
                                numberOfGuesses++;
                                Console.WriteLine("Datorn gissade för lågt. Försök igen.");
                                computerGuess = randomNumber.Next(computerGuess, 101);
                                continue;
                            }
                            else
                            {
                                numberOfGuesses++;
                                Console.WriteLine("Datorn gissade för högt. Försök igen.");
                                computerGuess = randomNumber.Next(1, computerGuess);
                                continue;
                            }
                        }
                        break;
                    }
                    else if (userInput == "x")
                    {
                        isExiting = true;
                        break;
                    }
                    else
                    {
                        Console.Write("Ange ett giltigt alternativ (j/n/x): ");
                        userInput = Console.ReadLine().ToLower();
                    }
                }
            }
        }

        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
