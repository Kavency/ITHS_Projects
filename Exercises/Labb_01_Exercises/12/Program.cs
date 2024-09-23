// 12.Rödmarkerade ord.
// Utgå från samma sträng igen, men denna gång ska programmet skriva ut hela strängen på varje rad.
// På första raden ska första ordet vara rött (övriga vita), på andra raden ska andra ordet vara rött.
// På tredje raden ska tredje vara rött osv.

string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string[] textArray = text.Split(' ');
int wordNumber = 1;

for (int i = 0; i < textArray.Length; i++)
{
    for (int j = 0; j < textArray.Length; j++)
    {
        if (wordNumber == j + 1)
            Console.ForegroundColor = ConsoleColor.Red;

        else
            Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write(textArray[j] + " ");
    }

    Console.WriteLine();
    wordNumber++;
}
Console.ForegroundColor = ConsoleColor.Gray;
