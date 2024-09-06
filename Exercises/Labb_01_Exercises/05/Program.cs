namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world";
            string newText = string.Empty;

            for (int i = 0; i < text.Length - 1; i++)
            {
                Console.ResetColor();

                if (i > 0 && text[i] == text[i - 1])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(text[i]);
                    
                }
                else if (text[i] == text[i + 1])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(text[i]);
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(text[i]);
                }
            }
        }
    }
}
