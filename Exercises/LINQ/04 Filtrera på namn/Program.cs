// 4.Filtrera på namn
// Filtrera arrayen från uppgift 1 så att du får en ny lista med 
// endast de användare vars förnamn är längre än efternamnet
// (d.v.s större antal bokstäver). I den nya listan vill vi att 
// objekten ska ha endast properties FirstName och LastName.

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 182, Weight = 37.4f },
      new { LastName = "Palm", FirstName = "Sandra",  Age = 40, Height = 198, Weight = 33.4f },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31, Height = 192, Weight = 89.6f },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 167, Weight = 76.8f },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 132, Weight = 23.2f },
      new { LastName = "Svensson",  FirstName = "Erika",  Age = 32, Height = 123, Weight = 76.6f },
      new { LastName = "Olofsson",  FirstName = "Sven",  Age = 25, Height = 167, Weight = 56.7f },
      new { LastName = "Karlsson",  FirstName = "Per Olof Stekare",  Age = 12, Height = 194, Weight = 87.6f } };

var names = people.Where(p => p.FirstName.Length > p.LastName.Length);

foreach (var item in names)
{
    Console.WriteLine($"{item.FirstName} has more characters than {item.LastName}.");
}