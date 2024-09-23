// 3.Verifiera lösenord
// Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett 
// hemligt lösenord och spara det i en variabel. När användaren har skrivit 
// in ett lösenord ska programmet jämföra med det sparade lösenordet och 
// skriva ut om det var rätt eller inte. Använd en if-sats.


string passWord = "abc123";

Console.Write("Please enter your super secure password in plain text: ");
string userInput = Console.ReadLine();

while (passWord != userInput)
{
    Console.WriteLine("Wrong password entered");
    Console.Write("Enter your password: ");
    userInput = Console.ReadLine();
}

Console.WriteLine("Correct!");
Console.ReadKey();
