// 6.Filtrera listan ovan på BMI
// Filtrera listan (från uppgift 5) så att du endast 
// får med personer med BMI under 20 eller BMI över 25.

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 1.82, Weight = 85 },
      new { LastName = "Palm", FirstName = "Sandra",  Age = 40, Height = 1.98, Weight = 92 },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31, Height = 1.92, Weight = 87 },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 1.67, Weight = 74 },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 1.32, Weight = 64 },
      new { LastName = "Svensson",  FirstName = "Erika",  Age = 47, Height = 1.78, Weight = 84 },
      new { LastName = "Olofsson",  FirstName = "Sven",  Age = 25, Height = 1.67, Weight = 74 },
      new { LastName = "Karlsson",  FirstName = "Per Olof Stekare",  Age = 12, Height = 1.94, Weight = 87 } };

var names = people
    .Select(p => new { FullName = $"{p.FirstName} {p.LastName}", BMI = p.Weight / (p.Height * p.Height) })
    .Where(p => p.BMI < 20 || p.BMI > 25);

foreach (var item in names)
{
    Console.WriteLine($"{item.FullName} - {item.BMI}");
}