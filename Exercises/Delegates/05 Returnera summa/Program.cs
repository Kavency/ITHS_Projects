// 5.Returnera summan av två värden
// Skapa ett generiskt delegat med ett lambda uttryck som tar 
// två tal och returnerar summan av dessa. Testa genom att
// anropa med två värden, och skriva ut resultatet.

// Declare generic delegate.   - Assign a Lambda.
Func<int, int, int> AddNumbers = (x, y) => x + y; ;

Console.WriteLine(AddNumbers(5, 5));
Console.WriteLine(AddNumbers(2, 3));