// 4.Skriv ut summan av två värden
// Skapa ett generiskt delegat med ett lambda uttryck 
// som tar två tal och skriver ut summan av dessa på 
// konsolen. Testa genom att anropa med två värden.


// Declare generic delegate.   - Assign a Lambda.
Func<int, int, int> AddNumbers = (x,y) => x + y; ;

Console.WriteLine(AddNumbers(5,5));
Console.WriteLine(AddNumbers(2,3));