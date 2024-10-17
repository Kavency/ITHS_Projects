// 9.Query syntax
// Lös alla uppgifter 2 - 8 med query-syntax 
// (om du använt method-syntax, annars tvärtom).

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 1.82, Weight = 85 },
      new { LastName = "Palm", FirstName = "Sandra",  Age = 40, Height = 1.98, Weight = 92 },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31, Height = 1.92, Weight = 87 },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 1.67, Weight = 74 },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 1.32, Weight = 64 },
      new { LastName = "Svensson",  FirstName = "Erika",  Age = 47, Height = 1.78, Weight = 84 },
      new { LastName = "Olofsson",  FirstName = "Sven",  Age = 25, Height = 1.67, Weight = 74 },
      new { LastName = "Karlsson",  FirstName = "Per Olof Stekare",  Age = 12, Height = 1.94, Weight = 87 } };

// 02...
var ageFilter = from person in people
                where person.Age >= 20 && person.Age <= 40
                select person;

//foreach (var item in ageFilter)
//{
//    Console.WriteLine($"{item.FirstName} - {item.Age}");
//}

// 03...
var tallFilter = from person in ageFilter
                 where person.Height > 1.9
                 select person;

//foreach (var item in tallFilter)
//{
//    Console.WriteLine($"{item.FirstName} - {item.Height}");
//}

// 04...
var onlyNames = from person in people
                where person.FirstName.Length > person.LastName.Length
                select new { FirstName = person.FirstName, LastName = person.LastName };

foreach (var item in onlyNames)
{
    Console.WriteLine($"{item.FirstName} {item.LastName}");
}