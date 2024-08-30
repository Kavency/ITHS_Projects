using System.Runtime.CompilerServices;
using System.Transactions;

namespace Variables_02
{
    internal class Program
    {
        // 2. Multiplicera två tal
        static void Main(string[] args)
        {
            string userInput;
            int firstNumber;
            int secondNumber;


            userInput = GetUserInput("Ange första talet");

            while (!Int32.TryParse(userInput, out firstNumber ))
            {
                userInput = GetUserInput("Vänligen ange ett heltal");
            }

            userInput = GetUserInput("Ange andra talet");

            while (!Int32.TryParse(userInput, out secondNumber))
            {
                userInput = GetUserInput("Vänligen ange ett heltal");
            }

            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");

        }

        private static string GetUserInput(string prompt)
        {
            Console.Write(prompt + " > ");
            return Console.ReadLine();
        }
    }
}
