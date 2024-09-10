// 15.Rödmarkerade bokstäver 3
// Användaren matar in valfri sträng. Programmet skriver sedan ut en hela strängen flera gånger.
// På första raden börjar den skriva med röd färg på första bokstaven och fram tills den
// hittar samma bokstav igen. På andra raden börjar den skriva med röd färg på andra bokstaven
// och fram tills den hittar samma bokstav igen. På tredje raden börjar den skriva med röd text
// på tredje bokstaven och fram tills den hittar samma igen... etc.

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;

            Console.Write("Enter a string: ");
            userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                for (int j = 0; j < userInput.Length; j++)
                {
                    Console.Write(userInput[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
