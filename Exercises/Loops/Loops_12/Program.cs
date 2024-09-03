// 12.Nio sifferpyramider
// Gör ett program som skriver ut “pyramider” som i uppgiften ovan,
// den första ska vara med en rad, följt av en pyramid med 2 rader,
// sen 3 rader etc. ända upp till 9 rader i den sista pyramiden.

namespace Loops_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "";
            int lineNumber = 0;

            for (int i = 1; i < 10; i++)
            {
                numbers += i.ToString();
                lineNumber++;

                if (lineNumber != 1 && lineNumber == numbers.Length)
                    Console.WriteLine();

                Console.WriteLine(numbers);
            }
        }
    }
}
