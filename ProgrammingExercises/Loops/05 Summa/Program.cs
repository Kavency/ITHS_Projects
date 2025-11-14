// 5.Summa
// Summan av alla tal 1 till 4, är 10 (1+2+3+4). Gör ett program som 
// räknar ut summan av alla tal 1 till 1000.

namespace Loops_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 1000;
            int total = 0;
            
            for (int i = 0; i <= maxNumber; i++)
            {
                total += i;
            }
            
            Console.WriteLine(total);

        }
    }
}
