namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world!!!otkdw88maGG";

            for (int i = 0; i < text.Length ; i++)
            {
                if (i > 0 && text[i] == text[i - 1])  // Kontrollera bokstaven innan index.
                    Console.ForegroundColor = ConsoleColor.Green;
                
                else if (text[i] == text[i + 1] && i != text.Length) // Kontrollera bokstaven efter index.
                    Console.ForegroundColor = ConsoleColor.Green;
                
                else
                    Console.ForegroundColor = ConsoleColor.Gray;
                
                Console.Write(text[i]);

                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
