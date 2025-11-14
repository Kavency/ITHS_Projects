// 11.Kasta tärning
// Skriv en funktion ThrowDice() som returnerar ett slumpmässigt heltal 1-6. 
// Skriv en annan funktion ThrowMultipleDice(int n) som returnerar resultatet 
// av att man slagit n tärningar.

// Extra utmaning: Lägg till en frivillig(optional) int på båda funktionerna, 
// där man kan ange antal sidor på tärningen (default 6).

while (true)
{
    Console.Clear();
    Console.WriteLine($"One die: {ThrowDice()}");
    Console.WriteLine($"Two dice: {ThrowMultiDice()}");
    Console.WriteLine("Press any key to roll again.");
    Console.ReadLine();
}

int ThrowDice(int noOfSides = 6)
{
    Random rnd = new();
    return rnd.Next(1, noOfSides + 1);
}
int ThrowMultiDice(int noOfSides = 6)
{
    Random rnd = new();
    return rnd.Next(1, noOfSides + 1) + rnd.Next(1, noOfSides + 1);
}