namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

            Console.Write("Enter a searchstring: ");
            string userInput = Console.ReadLine();

            if (text.Contains(userInput))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int subStringIndex = text.IndexOf(userInput, i);

                    if (i == subStringIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(userInput);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        i += userInput.Length - 1;
                    }
                    else
                        Console.Write(text[i]);
                }
            }
            else
                Console.WriteLine("Could not find your searchstring.");
        }
    }
}
