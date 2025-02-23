// 12.Sortering i första och andra hand
// Efter .OrderBy eller .OrderByDescending() kan man använda .ThenBy() 
// och .ThenByDescending() för att sortera på något annat i andra hand 
// (om flera objekt har samma värden i första sorteringen).
//
// Skriv ut alla personer (från uppgift 1) sorterade på efternamn 
// i stigande ordning (A -> Z). Om flera personer har samma efternamn, 
// sortera dessa på förnamn i fallande ordning (Z -> A).

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 1.82, Weight = 85 },
      new { LastName = "Palm", FirstName = "Sandra",  Age = 40, Height = 1.98, Weight = 92 },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 17, Height = 1.92, Weight = 87 },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 1.67, Weight = 74 },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 1.32, Weight = 64 },
      new { LastName = "Eriksson",  FirstName = "Mats",  Age = 65, Height = 1.32, Weight = 64 },
      new { LastName = "Eriksson",  FirstName = "Olof",  Age = 65, Height = 1.32, Weight = 64 },
      new { LastName = "Eriksson",  FirstName = "Vanessa",  Age = 65, Height = 1.32, Weight = 64 },
      new { LastName = "Svensson",  FirstName = "Erika",  Age = 47, Height = 1.78, Weight = 84 },
      new { LastName = "Olofsson",  FirstName = "Sven",  Age = 25, Height = 1.67, Weight = 74 },
      new { LastName = "Karlsson",  FirstName = "Per Olof Stekare",  Age = 12, Height = 1.94, Weight = 87 } };

var sorted = people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName);

foreach (var item in sorted)
{
    Console.WriteLine($"{item.FirstName} {item.LastName}");
}