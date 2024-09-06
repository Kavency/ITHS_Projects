using static System.Net.Mime.MediaTypeNames;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world";

            //for (int i = 0; i < text.Length; i++)
            foreach(char item in text)
            {
                Console.Write(item);



                //if (i > 0 && text[i] == text[i - 1])
                //{
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.Write(text[i - 1]);
                //    Console.Write(text[i]);
                //}
                //else
                //{
                //    Console.ForegroundColor = ConsoleColor.Gray;
                //    Console.Write(text[i]);
                //}

            }
        }
    }
}
