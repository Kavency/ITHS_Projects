// 7.Omvänd ordning
// Be användaren skriva in ett ord, sedan ett till, och ett till; 
// tills man skrivit in 7 ord. Skriv sedan ut orden på skärmen i 
// bakvänd ordning mot hur de matades in. Alltså ordet man skrev 
// in sist, skrivs ut först.

string[] userStrings = new string[7];

for(int i = 0; i < 7; i++)
{
    Console.Write($"Skriv in ord {i + 1}: ");
    userStrings[i] = Console.ReadLine();
}

for(int i = userStrings.Length - 1; i >= 0; i--)
{
    Console.WriteLine(userStrings[i]);
}