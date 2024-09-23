// 10.Ordpyramid
// Utgå från strängen “How much wood would a woodchuck chuck 
// if a woodchuck could chuck wood?”. Gör ett program som 
// skriver ut första ordet en gång på första raden; andra 
// ordet två gånger på nästa rad. Tredje ordet tre gånger 
// på nästa. etc.

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
