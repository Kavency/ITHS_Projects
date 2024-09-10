// 13.Rödmarkerade bokstäver
// Utgå från strängen "abcdefghijklmnopqrstuvwxyz". Hela strängen skrivs ut på varje rad. 
// På första raden är de 5 första tecknen röda. På nästa rad är “bcdef” röda, sedan “cedfg” osv.. 
// alltså alltid 5 tecken, men de flyttas ett steg åt höger för varje rad, tills sista raden har “vwxyz” 
// rödfärgad.

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    // j behöver vara lika med eller större än i för
                    // att skjuta fram den röda texten ett steg varje iteration.
                    if (j >= i && j < i + 5) 
                        Console.ForegroundColor = ConsoleColor.Red;
                    
                    else
                        Console.ForegroundColor = ConsoleColor.Gray;
                    
                    Console.Write(text[j]);
                }
                Console.WriteLine();
            }
            
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
