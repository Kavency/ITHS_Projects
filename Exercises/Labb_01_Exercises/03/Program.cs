namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world";

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write(text[i]);
            }

            Console.ReadKey();
        }
    }
}
