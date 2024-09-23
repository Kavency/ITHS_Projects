// 2.Bokstav för bokstav - radbyte på space
// Utgå från strängen "This is just some other text". 
// Skriv ut strängen bokstav för bokstav, men när det 
// kommer ett space, gör radbyte istället. 
// (Du ska få ett ord på varje rad).


string text = "Hello world";

foreach (char item in text)
{
    if (item == ' ')
    {
        Console.WriteLine();
        continue;
    }

    Console.Write(item);
}

Console.ReadKey();
