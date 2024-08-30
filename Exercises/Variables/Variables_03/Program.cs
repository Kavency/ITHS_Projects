namespace Variables_03
{
    internal class Program
    {
        // 3. Verifiera lösenord
        static void Main(string[] args)
        {
            string passWord = "abc123";

            Console.Write("Please enter your super secure password in plain text: ");
            string userInput = Console.ReadLine();

            while (passWord != userInput)
            {
                Console.WriteLine("Wrong password entered");
                Console.Write("Enter your password: ");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Correct!");
            Console.ReadKey();
        }
    }
}
