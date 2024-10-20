﻿// 6.Vattenglas
// Skriv en klass som representerar ett vattenglas. Den ska ha en metod för att fylla glaset, 
// och en metod för att tömma glaset. Dessutom ska den ha en private field som håller 
// reda på om glaset är tomt eller fullt. Beroende på tillståndet (tomt/fullt) så ska 
// metoden som fyller glaset skriva ut antingen “Fyller glaset” eller “Glaset är redan 
// fullt”. Den andra metoden ska skriva ut “Tömmer glaset” eller “Glaset är redan tomt”.

// Extra övning: Lägg till ytterligare en metod för att slå sönder glaset. Varje glas (instans) 
// ska hålla reda på sitt tillstånd, och skriva ut vad som händer när man kör de olika 
// metoderna. (t.ex “Glaset går sönder, och vattnet rinner ut på golvet”, eller “Glaset 
// kan inte fyllas, eftersom det är trasigt” osv.)

Glass glassOfWater = new();

glassOfWater.EmptyGlass();
glassOfWater.FillGlass();
glassOfWater.BreakGlass();
glassOfWater.EmptyGlass();
glassOfWater.FillGlass();
glassOfWater.BreakGlass();

class Glass
{
    private bool _isFull = false;
    private bool _isBroken = false;

    public void FillGlass()
    {
        if(!_isFull && !_isBroken)
        {
            Console.WriteLine("Glaset fylls på.");
            _isFull = true;
        }
        else if(_isFull && !_isBroken)
        {
            Console.WriteLine("Glaset är redan fullt.");
        }
        else
        {
            Console.WriteLine("Glaset är trasigt.");
        }
    }
    public void EmptyGlass()
    {
        if (_isFull && !_isBroken)
        {
            Console.WriteLine("Glaset töms.");
            _isFull = false;
        }
        else if (!_isFull && !_isBroken)
        {
            Console.WriteLine("Glaset är redan tomt.");
        }
        else
        {
            Console.WriteLine("Glaset är trasigt.");
        }
    }
    public void BreakGlass()
    {
        if(!_isBroken && _isFull)
        {
            Console.WriteLine("Glaset gick sönder och vätskan rann ut.");
            _isBroken = true;
        }
        else if(!_isBroken && !_isFull)
        {
            Console.WriteLine("Glaset gick sönder, tur att det var tomt.");
        }
        else
        {
            Console.WriteLine("Glaset är redan sönder.");
        }
    }
}