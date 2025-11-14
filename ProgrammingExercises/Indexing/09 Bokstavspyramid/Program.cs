// 9.Bokstavspyramid
// Skapa ett program som skriver ut första tecknet i "Hello World" på första raden, 
// de 2 första tecknen på andra raden osv.

string helloWorld = "Hello World!";

for (int i = 0; i < helloWorld.Length; i++)
{
	for (int j = 0; j <= i; j++)
	{
		Console.Write(helloWorld[j]);
	}
    Console.WriteLine();
}