// 6.Filtrera listan ovan på BMI
// Filtrera listan (från uppgift 5) så att du endast 
// får med personer med BMI under 20 eller BMI över 25.

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 182, Weight = 37.4f },
      new { LastName = "Palm", FirstName = "Sandra",  Age = 40, Height = 198, Weight = 33.4f },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31, Height = 192, Weight = 89.6f },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 167, Weight = 76.8f },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 132, Weight = 23.2f },
      new { LastName = "Svensson",  FirstName = "Erika",  Age = 47, Height = 178, Weight = 76.6f },
      new { LastName = "Olofsson",  FirstName = "Sven",  Age = 25, Height = 167, Weight = 56.7f },
      new { LastName = "Karlsson",  FirstName = "Per Olof Stekare",  Age = 12, Height = 194, Weight = 87.6f } };

var names = people.Select(p => new { FullName = $"{p.FirstName} {p.LastName}", BMI = p.Weight / (p.Height / 100 * p.Height / 100) });

foreach (var item in names.Where(p => p.BMI < 20 || p.BMI > 77))
{
    Console.WriteLine($"{item.FullName} - {item.BMI}");
}