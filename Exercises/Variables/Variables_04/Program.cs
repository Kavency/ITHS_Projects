namespace Variables_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int compareToValue = 100;
                
                Console.Write("Ange ett tal (x för att avsluta): ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "x")
                    break;

                if (!Int32.TryParse(userInput, out int result))
                    continue;

                if (result > compareToValue)
                    Console.WriteLine($"Talet är större än {compareToValue}!");
                else if (result < compareToValue)
                    Console.WriteLine($"Talet är mindre än {compareToValue}!");
                else
                    Console.WriteLine($"Talet är exakt {compareToValue}!");
            }


        }
    }
}
