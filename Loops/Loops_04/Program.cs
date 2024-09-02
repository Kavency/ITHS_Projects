namespace Loops_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett tal: ");
            string userInput = Console.ReadLine();

            int.TryParse(userInput, out int result);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(result * i);
            }
        }
    }
}
