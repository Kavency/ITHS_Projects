// 2.Jämna tal
// Skriv en loop som skriver ut alla jämna tal från 0 till 30.

namespace Loops_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
