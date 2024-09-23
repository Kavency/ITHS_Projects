// 1.Sifferpyramid
// Gör ett program som skriver “1” på första raden, “12” på nästa,
// sen “123” osv upp till rad 9 där det står “123456789”

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
