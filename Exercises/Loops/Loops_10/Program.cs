// 10.Ihålig box
// Fråga efter bredd och höjd och skriv ut en
// “box” som inte är fylld.

namespace Loops_10
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
                    if (j == 1 || j >= width || i == 1 || i == height)
                    {
                        Console.Write("X");
                    }
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
