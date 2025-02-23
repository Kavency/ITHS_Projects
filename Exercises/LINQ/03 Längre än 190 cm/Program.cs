// 3.Är någon längre än 190 cm?
// Är någon av personerna mellan 20 och 40 år längre än 190 cm lång?

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 182, Weight = 37.4f },
      new { LastName = "Palm", FirstName = "Lisa",  Age = 40, Height = 198, Weight = 33.4f },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31, Height = 192, Weight = 89.6f },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 167, Weight = 76.8f },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 132, Weight = 23.2f },
      new { LastName = "Svensson",  FirstName = "Erika",  Age = 32, Height = 123, Weight = 76.6f },
      new { LastName = "Olofsson",  FirstName = "Sven",  Age = 25, Height = 167, Weight = 56.7f },
      new { LastName = "Karlsson",  FirstName = "Olof",  Age = 12, Height = 194, Weight = 87.6f } };

var agesBetween = people.Where(p => p.Height > 190);

foreach (var item in agesBetween)
{
    Console.WriteLine($"{item.FirstName} is {item.Height}cm tall.");
}