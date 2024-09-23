// 8.Bokstav för bokstav - grön substring 3
// Samma som uppgift 6 igen, men denna gången kan användaren mata in 
// den kortare strängen, alltså valfri text som ska sökas (färgas grön) 
// i den längre texten.

string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

Console.Write("Enter a searchstring: ");
string userInput = Console.ReadLine();

if (text.Contains(userInput))
{
    for (int i = 0; i < text.Length; i++)
    {
        int subStringIndex = text.IndexOf(userInput, i);

        if (i == subStringIndex)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(userInput);
            Console.ForegroundColor = ConsoleColor.Gray;
            i += userInput.Length - 1;
        }
        else
            Console.Write(text[i]);
    }
}
else
    Console.WriteLine("Could not find your searchstring.");
