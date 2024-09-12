// 1.En bokstav på varje rad.
// Be användaren mata in en sträng. 
// Skriv ut varje tecken i strängen på en egen rad.

namespace Indexing_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            foreach (char item in userInput)
            {
                Console.WriteLine(item);
            }
        }
    }
}
