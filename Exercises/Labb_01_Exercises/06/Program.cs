namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string subString = "oo";

            Console.WriteLine("How much wood would a woodchuck chuck if a woodchuck could chuck wood?");

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'o' && text[i + 1] == 'o' && i != text.Length)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(subString);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    i += 1;
                }
                else
                    Console.Write(text[i]);
            }
        }
    }
}
