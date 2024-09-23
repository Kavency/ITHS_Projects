// 7.Bokstav för bokstav - grön substring 2
// Samma som uppgift 6, men den mindre strängen är "chuck" istället för 
// "oo". D.v.s. alla gånger "chuck" förekommer i den längre strängen 
// skrivs dessa med grön text.

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
