namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";

            foreach(char item in text)
            {
                Console.ResetColor();

                if (item.ToString().ToLower() == "o")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(item);
                }
                else if (item.ToString().ToLower() == "l")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(item);
                }
                else
                    Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
