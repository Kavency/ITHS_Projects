// 8.Username tillsammans med Category
// Skapa en ny lista från arrayen (i uppgift 1) som innehåller objekt
// med properties Username (förnamnet + åldern, ex. “Kalle23”), 
// samt Category (som har värdet “Child” eller “Adult” beroende 
// på om personen är under 18 eller inte).


var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 1.82, Weight = 85 },
      new { LastName = "Palm", FirstName = "Sandra",  Age = 40, Height = 1.98, Weight = 92 },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 17, Height = 1.92, Weight = 87 },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 1.67, Weight = 74 },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 1.32, Weight = 64 },
      new { LastName = "Svensson",  FirstName = "Erika",  Age = 47, Height = 1.78, Weight = 84 },
      new { LastName = "Olofsson",  FirstName = "Sven",  Age = 25, Height = 1.67, Weight = 74 },
      new { LastName = "Karlsson",  FirstName = "Per Olof Stekare",  Age = 12, Height = 1.94, Weight = 87 } };

var newList = people.Select(p => new { UserName = $"{p.FirstName}{p.Age}", Category = p.Age < 18 ? "Child" : "Adult" });

foreach (var item in newList)
{
    Console.WriteLine($"{item.UserName} - {item.Category}");
}
