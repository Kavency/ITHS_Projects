// 12.Nio sifferpyramider
// Gör ett program som skriver ut “pyramider” som i uppgiften ovan,
// den första ska vara med en rad, följt av en pyramid med 2 rader,
// sen 3 rader etc. ända upp till 9 rader i den sista pyramiden.

namespace Loops_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "";
            int rowNumber = 0;
            //List<string> numberList = new List<string>();

            //for (int i = 1; i < 10; i++)
            //{
            //    numbers += i.ToString();
            //    numberList.Add(numbers);
            //}

            //for (int i = 0; i < numberList.Count; i++)
            //{
            //    for (int j = 0; j <= rowNumber; j++)
            //    {
            //        Console.WriteLine(numberList[j]);
            //    }
            //    Console.WriteLine();
            //    rowNumber++;
            //}



            string numbersTwo = "123456789";

            for (int i = 0; i < rowNumber; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(numbersTwo[j]);
                    if (j == rowNumber - 1)
                    {
                        Console.WriteLine();
                    }

                }
                Console.WriteLine();
                rowNumber++;
            }
        }
    }
}
