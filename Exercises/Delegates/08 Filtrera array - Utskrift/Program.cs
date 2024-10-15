// 8.Filtrera array(utskrift)
// Skapa en metod som tar en array med heltal, samt ett delegat som tar 
// en int som inparameter och returnerar en bool. Metoden ska sedan anropa 
// delegatet för varje tal i arrayen och endast skriva ut de tal som 
// returnerar true.
//
// Skapa en int[] med 10 tal som du kan skicka in i metoden:
//
// Gör 3 anrop till metoden:
//
// Ett som listar alla negativa tal
// Ett som listar alla tal mellan 10 och 20
// Ett som listar alla jämna tal

int[] numbers = { 2, -5, 34, 23, 87, 7, -95, 56, -32, 14 };

Console.WriteLine("Negative numbers:");
CheckNumbers(numbers, x => x < 0);
Console.WriteLine("Numbers between 10 an 30:");
CheckNumbers(numbers, x => x > 10 && x < 30);
Console.WriteLine("Even numbers:");
CheckNumbers(numbers, x => x % 2 == 0);


void CheckNumbers(int[] numbers, Func<int, bool> func)
{
	foreach (int number in numbers)
	{
		if (func(number))
		{
            Console.WriteLine(number);
		}
	}
}