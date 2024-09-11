namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world";

            foreach (char item in text)
            {
                if (item == ' ')
                {
                    Console.WriteLine();
                    continue;
                }

                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
