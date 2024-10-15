// 4.Skriv ut summan av två värden
// Skapa ett generiskt delegat med ett lambda uttryck 
// som tar två tal och skriver ut summan av dessa på 
// konsolen. Testa genom att anropa med två värden.


// Declare generic delegate.   - Assign a Lambda.
Action<int, int> AddNumbers = (x,y) => Console.WriteLine(x + y);

AddNumbers(5, 5);
AddNumbers(2, 3);
