// 11.Ordpyramid 2
// Utgå från strängen “How much wood would a woodchuck chuck if 
// a woodchuck could chuck wood?”. Gör ett program som på 
// första raden skriver ut första ordet. På nästa rad skriver 
// ut de två första orden, sedan de tre första orden på nästa 
// rad o.s.v till man kommit till raden som skriver ut hela meningen. 

Console.Clear();
string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string[] textArray = text.Split(' ');
string result = string.Empty;

foreach (string item in textArray)
{
    result += item + " ";
    Console.WriteLine(result);
}
