// 1.Bokstav för bokstav - fram till space
// Utgå från strängen (skapa en variabel med) "Hello World!", 
// skriv ut hela strängen bokstav för bokstav, men avsluta när 
// det kommer ett space. (Den ska alltså bara skriva “Hello”).


string text = "Hello world";

foreach (char item in text)
{
    if (item == ' ')
        break;

    Console.Write(item);
}

Console.ReadKey();
