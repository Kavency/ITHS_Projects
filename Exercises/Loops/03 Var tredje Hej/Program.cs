// 3.Var tredje "Hej"
// Skriv en loop som skriver ut tal från 0 till 30, 
// men om talet är jämnt delbart med 3 skriv istället “Hej”.

namespace Loops_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine($"{i} är jämnt delbart med tre.");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
