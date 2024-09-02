using System.ComponentModel.Design;

namespace Loops_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine($"{i} är jämnt delbart med tre.");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
