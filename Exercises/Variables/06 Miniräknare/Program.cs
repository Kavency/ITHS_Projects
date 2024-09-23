// 6.Miniräknare
// Skriv ett program som först frågar efter ett tal, sedan frågar efter 
// ett av följande tecken: +, -, *eller /.Därefter ska ytterligare 
// ett tal efterfrågas. Programmet ska fungera som en simpel miniräknare. 
// Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet 
// skriva ut “3 * 5 = 15”.


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

    if (!double.TryParse(secondInput, out secondResult))
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

