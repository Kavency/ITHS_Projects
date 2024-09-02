namespace Variables_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Ange ett tal: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "x")
                    break;

                if (!double.TryParse(userInput, out double result))
                    continue;

                Console.WriteLine($"{result * 2} är dubbelt så mycket som {result}");
                Console.WriteLine($"{result / 2} är hälften så mycket som {result}");
            }

        }
    }
}
