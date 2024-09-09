namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string subString = "chuck";



            if (text.Contains(subString))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int subStringIndex = text.IndexOf(subString, i);

                    if (i == subStringIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(subString);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        i += 4;
                    }
                    else
                        Console.Write(text[i]);
                }
            }
        }
    }
}
