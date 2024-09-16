// 4.Dölj vokaler
// Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

char[] vokaler = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
string vokalerString = "aeiouyåäö"; // Enklaste lösningen är med en sträng.

Console.Write("Enter any text: ");
string userInput = Console.ReadLine();

Console.WriteLine();

for (int i = 0; i < userInput.Length; i++)
{
    if (vokalerString.Contains(userInput[i])) // Ingen kontroll av versaler sker.
        Console.Write('*');
    else
        Console.Write(userInput[i]);
}

for (int i = 0; i < userInput.Length; i++)
{
    bool isVokal = false; // Minns inte vad vokal heter på engelska.
    foreach(var vokal in vokaler)
    {
        if(vokal == userInput[i])
            isVokal = true;
    }
}