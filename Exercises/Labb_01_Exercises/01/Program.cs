namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world";

            foreach(char item in text)
            {
                if (item == ' ')
                    break;

                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
