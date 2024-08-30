namespace Variables_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ditt namn: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Välkommen {userName}!");

            Console.ReadKey();
        }
    }
}
