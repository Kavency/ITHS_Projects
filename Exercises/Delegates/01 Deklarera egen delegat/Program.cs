// 1.Deklarera en egen delegat-typ
// Skriv en metod som tar två strängar: firstName och lastName.
// Metoden ska returnera en ny sträng som är hela namnet. Deklarera 
// en delegat-typ, och gör en variabel som är en referens till 
// metoden. Anropa metoden via delegatet.





string GetFullName(string firstName, string lastName) 
{
    return $"{firstName} {lastName}";
}
