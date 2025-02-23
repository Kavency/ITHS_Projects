// 2.Filtrera på ålder
// Filtrera arrayen (uppgift 1) så du får en ny lista med 
// endast de användare som är mellan 20 och 40 år gamla.

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 1.82f, Weight = 37.4f },
      new { LastName = "Palm", FirstName = "Lisa",  Age = 40, Height = 1.98f, Weight = 33.4f },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31, Height = 1.42f, Weight = 89.6f },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 1.67f, Weight = 76.8f },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 1.32f, Weight = 23.2f },
      new { LastName = "Svensson",  FirstName = "Erika",  Age = 32, Height = 1.23f, Weight = 76.6f },
      new { LastName = "Olofsson",  FirstName = "Sven",  Age = 25, Height = 1.67f, Weight = 56.7f },
      new { LastName = "Karlsson",  FirstName = "Olof",  Age = 12, Height = 1.87f, Weight = 87.6f } };

var agesBetween = people.Where(p => p.Age > 20 && p.Age < 40);

foreach (var item in agesBetween)
{
    Console.WriteLine($"{item.FirstName} is {item.Age} years old.");
}