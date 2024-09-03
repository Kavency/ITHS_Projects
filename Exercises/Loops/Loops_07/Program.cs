// 7.Fylld box
// Gör ett program som ber användaren mata in höjd och bredd.
// Printa ut en “box” med bokstaven X på skärmen med den höjd
// och bredd som matats in.

namespace Loops_07
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
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
