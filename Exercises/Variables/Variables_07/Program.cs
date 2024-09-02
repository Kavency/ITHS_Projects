namespace Variables_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = 0;
            double total = 0;

            do
            {
                Console.Write("Mata in ett värde: ");
                string userInput = Console.ReadLine();

                if (double.TryParse(userInput, out double result))
                {
                    total += result;
                    numberOfInputs++;
                    Console.WriteLine($"Summa = {total}");
                }
                else if (userInput == "")
                {
                    Console.WriteLine($"Medelvärde = {total / numberOfInputs}");
                    break;
                }
                else
                    continue;

            } while (true);
        }
    }
}
