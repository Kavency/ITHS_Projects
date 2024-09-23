// 6.Riskorn på shackbräde
// Enligt legenden så fick den man som hade konstruerat 
// det formidabla spelet schack önska sig något värdefullt 
// av den överförtjuste kungen. Monarken blev förvånad över 
// uppfinnarens anspråkslöshet när gåvan skulle bestå av riskorn.

// Antalet riskorn bestämdes enligt följande regel: ett korn 
// skulle lämnas för första rutan på ett schackbräde, 
// två korn för andra rutan, fyra för tredje, 
// åtta för fjärde och så ändå till den sista rutan.

// Skriv ett program som hjälper kungen att beräkna 
// antalet riskorn på vardera ruta.


namespace Loops_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 1;

            for (int i = 0; i <= 64; i++)
            {
                Console.WriteLine(sum *= 2);
            }
        }
    }
}
