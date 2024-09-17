// 7.Beräkna medelvärde av int-array
// Skriv en funktion som tar en int[] in, 
// och returnerar medelvärdet som en double.

int[] numbers = new int[] { 10, 4, 6, 3, 9, 12, 6, 3, 9, 5 };

Console.WriteLine(CalculateAverage(numbers));

double CalculateAverage(int[] values)
{
    double total = 0;

    foreach(int value in values)
    {
        total += value;
    }

    return total / values.Length;
}