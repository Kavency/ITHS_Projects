namespace Loops_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 1;

            for (int i = 0; i <= 64; i++)
            {
                Console.WriteLine(sum *= 2);
            }
        }
    }
}
