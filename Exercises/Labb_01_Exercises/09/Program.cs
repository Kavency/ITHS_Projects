namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(text[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
