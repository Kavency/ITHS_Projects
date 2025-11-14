// 8.Fördröjd utskrift
// Skapa ett program som ber användaren att skriva in ett ord. Sedan ett till, 
// och ett till i all evighet. Varje gång man skrivit in ett ord så ska 
// programmet skriva ut det ord man skrev 10 inmatningar tidigare. Men om man 
// inte skrivit in 10 ord än så kan den istället skriva just det: 
// “Du har inte skrivit in 10 ord än.”

List<string> userWords = new List<string>();
int i = 1;

while (true)
{
    Console.Write($"Skriv in ord {i}: ");
    userWords.Add(Console.ReadLine());

    if(i >= 10)
        Console.WriteLine(userWords[i - 10]);
    else
        Console.WriteLine("Skriv in minst 10 ord.");
    i++;
}
