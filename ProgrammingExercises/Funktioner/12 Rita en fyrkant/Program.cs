// 12.Rita en box
// Skriv en funktion DrawBox(int width, int height). När man anropar 
// funktionen ska den skriva ut en rektangel där de yttre tecknen 
// består av ‘#’ och de inre av ‘-’.

DrawBox(25, 25);


void DrawBox(int width, int height)
{
	for (int i = 0; i < height; i++)
	{
		for (int j = 0; j < width; j++)
		{
			if(i == 0 || i == height - 1 || j == 0 || j == width - 1)
			{
				Console.Write("*");
			}
			else
			{
				Console.Write("-");
			}
		}
        Console.WriteLine();
	}
}