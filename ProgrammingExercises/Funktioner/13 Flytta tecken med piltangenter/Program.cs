// 13.Flytta runt ett @ med piltangenterna.
// Använd DrawBox-funktionen i föregående uppgift för att rita en box på skärmen. 
// Placera sedan ett @ i mitten av boxen. Om man använder piltangenterna ska man 
// kunna flytta runt @. När den kommer till kanten av boxen så ska den inte kunna
// gå längre åt det hållet.

// Tips: För att flytta @ behöver du skriva ‘-’ på dess tidigare position 
// och ‘@’ på den nya positionen. Spara bredd och höjd på boxen så du vet när den 
// ska stanna.
int width = 20;
int height = 15;

int playerX = width / 2;
int playerY = height / 2;

Console.CursorVisible = false;

DrawBox(width, height);

ConsoleKeyInfo keyPressed; ;

while (true)
{
    Console.SetCursorPosition(playerX, playerY);
    Console.Write('O');
    Thread.Sleep(50);

    keyPressed = Console.ReadKey(true);
    if (keyPressed.Key == ConsoleKey.A || keyPressed.Key == ConsoleKey.D
        || keyPressed.Key == ConsoleKey.S 
        || keyPressed.Key == ConsoleKey.W)
    {
        if(keyPressed.Key == ConsoleKey.A)
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(" ");
            playerX -= 1;
            Console.SetCursorPosition(playerX, playerY);
            Console.Write('O');
        }
        else if (keyPressed.Key == ConsoleKey.D)
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(" ");
            playerX += 1;
            Console.SetCursorPosition(playerX, playerY);
            Console.Write('O');
        }
        else if (keyPressed.Key == ConsoleKey.S)
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(" ");
            playerY += 1;
            Console.SetCursorPosition(playerX, playerY);
            Console.Write('O');
        }
        else
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(" ");
            playerY -= 1;
            Console.SetCursorPosition(playerX, playerY);
            Console.Write('O');
        }
    }
}








void DrawBox(int width, int height)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                Console.Write("*");
            
            else
                Console.Write(" ");
        }
        
        Console.WriteLine();
    }
}