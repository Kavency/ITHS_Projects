namespace Loops_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "";
            int lineNumber = 1;

            for (int i = 1; i < 10; i++)
            {
                numbers += i.ToString();
                Console.WriteLine(numbers);
            }
        }
    }
}
