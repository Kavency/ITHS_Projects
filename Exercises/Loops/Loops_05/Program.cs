namespace Loops_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 1000;
            int total = 0;
            
            for (int i = 0; i <= maxNumber; i++)
            {
                total += i;
            }
            
            Console.WriteLine(total);

        }
    }
}
