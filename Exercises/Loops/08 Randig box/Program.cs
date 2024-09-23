// 8.Randig box
// Samma som uppgift 7, 
// men för varannan kolumn skrivs bokstaven O istället för X.

namespace Loops_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;

            do
            {
                Console.Write("Ange bredd: ");
            } while (!Int32.TryParse(Console.ReadLine(), out width));

            do
            {
                Console.Write("Ange höjd: ");
            } while (!Int32.TryParse(Console.ReadLine(), out height));

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("O");
                    }
                    else
                        Console.Write("X");
                }

                Console.WriteLine();
            }
        }
    }
}
