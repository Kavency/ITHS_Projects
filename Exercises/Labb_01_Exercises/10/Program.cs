namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            int subStringIndex = 0;
            int noOfPrintsOut = 1;

            for (int i = 0; i <= text.Length; i++)
            {
                subStringIndex = text.IndexOf(" ", 0);

                for (int j = 0; j < noOfPrintsOut; j++)
                {
                    Console.Write(text.Substring(0, subStringIndex + 1));
                }

                Console.WriteLine();
                text = text.Remove(0, subStringIndex + 1);
                noOfPrintsOut++;
            }

            for (int j = 0; j < noOfPrintsOut; j++)
            {
                Console.Write(text + " ");
            }
        }
    }
}
