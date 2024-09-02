namespace Loops_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;
            int evenUnevenToggle = 1;

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
                    if (evenUnevenToggle > 0)
                    {
                        Console.Write("O");
                    }
                    else
                        Console.Write("X");

                    evenUnevenToggle *= -1;
                }

                Console.WriteLine();
            }
        }
    }
}
