namespace Loops_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "";

            for (int i = 1; i < 10; i++)
            {
                numbers += i.ToString();
                Console.WriteLine(numbers);
            }
        }
    }
}
