// 9.Bokstavspyramid
// Utgå från strängen "Hello world!". Gör ett program som 
// skriver ut första bokstaven en gång på första raden. 
// Andra bokstaven 2 gånger på andra raden. 
// Tredje 3 gånger på nästa rad osv.

string text = "Hello, World!";

for (int i = 0; i < text.Length; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(text[i]);
    }
    Console.WriteLine();
}
