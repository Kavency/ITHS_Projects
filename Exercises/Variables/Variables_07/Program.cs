// 7.Summa och medelvärde
// Skriv ett program som upprepade gånger frågar användaren 
// efter ett tal ända till man skriver något som inte är 
// ett tal (t.ex bara trycker enter). Efter varje inmatning 
// ska summan av alla tal som matats in skrivas ut, innan 
// nästa inmatning efterfrågas. Innan programmet avslutas 
// ska man även skriva ut medelvärde av de inmatade talen.


int numberOfInputs = 0;
double total = 0;

do
{
    Console.Write("Mata in ett värde: ");
    string userInput = Console.ReadLine();

    if (double.TryParse(userInput, out double result))
    {
        total += result;
        numberOfInputs++;
        Console.WriteLine($"Summa = {total}");
    }
    else if (userInput == "")
    {
        Console.WriteLine($"Medelvärde = {total / numberOfInputs}");
        break;
    }
    else
        continue;

} while (true);
