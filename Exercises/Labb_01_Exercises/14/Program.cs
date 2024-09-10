// 14.Rödmarkerade bokstäver 2
// Användaren matar in valfri sträng. Programmet skriver ut hela strängen
// bokstav för bokstav. Alla bokstäverna är röda fram tills du stöter på ett 
// tecken som är samma som första tecknet i strängen. Därefter skriver den ut
// resten av bokstäverna med vit/grå färg.

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;
            
            Console.Write("Enter a string:> ");
            userInput = Console.ReadLine();

            // Skriv ut sträng bokstav för bokstav.
            for (int i = 0; i < userInput.Length; i++)
            {
                Console.Write(userInput[i]);
            }

        }
    }
}
