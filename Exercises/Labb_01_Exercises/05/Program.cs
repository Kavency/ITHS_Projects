namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world!!!";

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (i > 0 && text[i] == text[i - 1])
                    Console.ForegroundColor = ConsoleColor.Green;

                else if (text[i] == text[i + 1])
                    Console.ForegroundColor = ConsoleColor.Green;

                else
                    Console.ForegroundColor = ConsoleColor.Gray;
                
                Console.Write(text[i]);

                if (i == text.Length - 2)
                {
                    if (text[i] == text[i + 1])
                        Console.ForegroundColor = ConsoleColor.Green;

                    else
                        Console.ForegroundColor = ConsoleColor.Gray;
                    
                    Console.WriteLine(text[i + 1]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
            }
        }
    }
}
