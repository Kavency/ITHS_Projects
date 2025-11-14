// 9.Filtrera array(till ny array)
// Gör om metoden i uppgift 8 så att den istället för att
// skriva ut talen returnerar en ny array med de tal
// som matchar villkoren i lambdautrycket man skickar in.

int[] numbers = { 2, -5, 34, 23, 87, 7, -95, 56, -32, 14 };

Console.WriteLine("Negative numbers from new array:");
int[] negativeNumbers = CheckNumbers(numbers, x => x < 0);
foreach (var item in negativeNumbers)
{
    Console.WriteLine(item);
}

Console.WriteLine("Numbers between 10 an 30 from new array:");
int[] betweenNumbers = CheckNumbers(numbers, x => x > 10 && x < 30);
foreach (var item in betweenNumbers)
{
    Console.WriteLine(item);
}

Console.WriteLine("Even numbers from new array:");
int[] evenNumbers = CheckNumbers(numbers, x => x % 2 == 0);
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}

int[] CheckNumbers(int[] numbers, Func<int, bool> func)
{
    List<int> resultList = new();
    foreach (int number in numbers)
    {
        if (func(number))
        {
            resultList.Add(number);
        }
    }
    return resultList.ToArray();
}