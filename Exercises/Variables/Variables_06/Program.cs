namespace Variables_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstResult;
            double secondResult;

            while (true)
            {
                Console.Write("Ange första talet: ");
                string firstInput = Console.ReadLine();
                
                if (!double.TryParse(firstInput, out firstResult))
                    continue;

                Console.Write("Ange operation (+,-,*,/): ");
                string operatorInput = Console.ReadLine();

                if (operatorInput != "+" && operatorInput != "-" && operatorInput != "*" && operatorInput != "/")
                    continue;
                
                Console.Write("Ange andra talet: ");
                string secondInput = Console.ReadLine();

                if (!double.TryParse(secondInput, out  secondResult))
                    continue;

                switch (operatorInput)
                {
                    case "+":
                        Console.WriteLine($"{firstInput} {operatorInput} {secondInput} = {firstResult + secondResult}");
                        break;
                    case "-":
                        Console.WriteLine($"{firstInput} {operatorInput} {secondInput} = {firstResult - secondResult}");
                        break;
                    case "*":
                        Console.WriteLine($"{firstInput} {operatorInput} {secondInput} = {firstResult * secondResult}");
                        break;
                    case "/":
                        Console.WriteLine($"{firstInput} {operatorInput} {secondInput} = {firstResult / secondResult}");
                        break;
                    default:
                        break;
                }

            }


        }
    }
}
