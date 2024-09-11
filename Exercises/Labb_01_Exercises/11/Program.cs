namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string[] textArray = text.Split(' ');
            string result = string.Empty;

            foreach (string item in textArray)
            {
                result += item + " ";
                Console.WriteLine(result);
            }
        }
    }
}
