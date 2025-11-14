// 13.LINQ vs PLINQ
// Använd Enumerable.Range() för att skapa en sekvens av tal 
// från 1 upp till 1 miljard. Filtrera sedan sekvensen på så 
// vis att du får endast de tal som är jämnt delbara med 3 
// eller 5. Beräkna summan av talen.
//
// OBS! Använd inte ToList() ovan, då detta till skillnad från 
// Enumerable faktiskt skapar upp alla tal i minnet.
//
// Sätt breakpoints i din kod och använd debuggern för 
// att kolla hur lång tid det tar att exekvera.
//
// Prova sedan att köra samma beräkning som parallell LINQ; 
// jämför tiden det tar att exekvera.
ulong sum = 0;

var numbers = Enumerable.Range(1, 1000_000_000);

// Using LINQ method-syntac
var LINQNums = numbers.Where(n => n % 3 == 0 || n % 5 == 0);

// Using PLINQ
var PLINQNums = numbers.AsParallel().Where(n => n % 3 == 0 || n % 5 == 0);

foreach (var item in LINQNums) // 10 400ms using LINQ.
{
    sum += (ulong)item;
    //Console.WriteLine(item);
}
Console.WriteLine($"\r\nTotal with LINQ: {sum}");

sum = 0;

foreach (var item in PLINQNums) // 15 900ms using PLINQ.
{
    sum += (ulong)item;
    //Console.WriteLine(item);
}


Console.WriteLine($"\r\nTotal with PLINQ: {sum}");