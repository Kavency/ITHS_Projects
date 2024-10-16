﻿// 2.Siffror till text
// Skapa ett program med en array som innehåller strängarna 
// “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
// Be sedan användaren att mata in en siffra. Använd arrayen för att skriva
// ut siffrans ord. Ex. Inmatning “3” => “tre”.

namespace _02_Siffror_till_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsText = { "Zero", "One", "Two", "Three", 
                "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            
            while (true)
            {
                Console.Write("Enter a single digit: ");
                string userInput = Console.ReadLine();

                if (userInput != "" && char.IsDigit(userInput[0]) && userInput.Length == 1)
                {
                    Console.WriteLine(numbersAsText[Int32.Parse(userInput)]);
                }
            }
        }
    }
}
