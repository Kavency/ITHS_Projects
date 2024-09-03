// 13.Primtal
// Primtal är heltal större än 1 som inte går att jämnt dela med något
// annat heltal (förutom 1 eller talet själv, eftersom alla tal är delbara 
// med sig själva och 1). De 5 första primtalen är 2, 3, 5, 7, 11. Skriv ett
// program som listar de första 20 primtalen.

namespace _13_Primtal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 100; // Anger högsta nummer att kontrollera.
            int numberToCheck = 3; // Aktuellt nummer att kontrollera. Börjar på 3 eftersom vi vet att 2 är lägsta primtal.
            int divisableCounter = 0; // Anger hur många gånger ett tal kan delas.
            int numberOfPrimeFound = 1; // Börja med 1 eftersom vi redan har första primtalet (2).

            Console.WriteLine("De första 20 primtalen:");
            Console.WriteLine("2"); // Skriv ut 2 direkt eftersom vi vet att det är det minsta primtalet.

            for (int i = 1; i <= maxNumber / 2; i++)  // Dela maxNumber med 2 eftersom vi bara kollar ojämna tal och därmed ökar numberToCheck med 2 varje iteration.
            {
                for (int j = 1; j <= numberToCheck; j++)
                {
                    if (numberToCheck % j == 0)
                        divisableCounter++;
                }

                if (divisableCounter == 2)
                {
                    Console.WriteLine(numberToCheck);
                    numberOfPrimeFound++;
                }

                if (numberOfPrimeFound == 20)
                    break;
                
                divisableCounter = 0;
                numberToCheck += 2; // Öka med två eftersom vi endast behöver kolla ojämna nummer.
            }

        }
    }
}
