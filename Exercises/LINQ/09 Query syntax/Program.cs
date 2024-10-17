// 9.Query syntax
// Lös alla uppgifter 2 - 8 med query-syntax 
// (om du använt method-syntax, annars tvärtom).

using System;

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39, Height = 1.82, Weight = 85 },
      new { LastName = "Palm", FirstName = "Sandra",  Age = 40, Height = 1.98, Weight = 92 },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 17, Height = 1.92, Weight = 87 },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66, Height = 1.67, Weight = 74 },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65, Height = 1.32, Weight = 64 },
      new { LastName = "Svensson",  FirstName = "Erika",  Age = 47, Height = 1.78, Weight = 84 },
      new { LastName = "Olofsson",  FirstName = "Sven",  Age = 25, Height = 1.67, Weight = 74 },
      new { LastName = "Karlsson",  FirstName = "Per Olof Stekare",  Age = 12, Height = 1.94, Weight = 87 } };

// 02...
var ageFilter = from person in people
                where person.Age >= 20 && person.Age <= 40
                select person;

Console.WriteLine("- Ages ranging from 20 to 40...");
foreach (var item in ageFilter)
{
    Console.WriteLine($"{item.FirstName} - {item.Age}");
}

// 03...
var tallFilter = from person in ageFilter
                 where person.Height > 1.9
                 select person;

Console.WriteLine("\r\n- People taller than 1.90m...");
foreach (var item in tallFilter)
{
    Console.WriteLine($"{item.FirstName} - {item.Height}");
}

// 04...
var onlyNames = from person in people
                where person.FirstName.Length > person.LastName.Length
                select new { FirstName = person.FirstName, LastName = person.LastName };

Console.WriteLine("\r\n- People with firstname longer than lastname...");
foreach (var item in onlyNames)
{
    Console.WriteLine($"{item.FirstName} {item.LastName}");
}

// 05...
var nameBMI = from person in people
              select new { FullName = $"{person.FirstName} {person.LastName}", BMI = person.Weight / Math.Pow(person.Height, 2) };

Console.WriteLine("\r\n- People with full name and BMI...");
foreach (var item in nameBMI)
{
    Console.WriteLine($"{item.FullName} - {item.BMI:F2}");
}

// 06...
var newBMI = from person in nameBMI
             where person.BMI >= 20 && person.BMI <= 25
             select person;

Console.WriteLine("\r\n- People with BMI between 20 and 25...");
foreach (var item in newBMI)
{
    Console.WriteLine($"{item.FullName} - {item.BMI:F2}");
}

// 07...
var newBMI2 = from person in people
             where person.Weight / Math.Pow(person.Height, 2) >= 20 && person.Weight / Math.Pow(person.Height, 2) <= 25
              select person;

Console.WriteLine("\r\n- People with BMI between 20 and 25...");
foreach (var item in newBMI2)
{
    Console.WriteLine($"{item.FirstName} - {item.Weight / Math.Pow(item.Height, 2):F2}");
}

// 08...
var userNames = from person in people
                select new { UserName = $"{person.FirstName}{person.Age}", Category = person.Age < 18 ? "Child" : "Adult" };

Console.WriteLine("\r\n- Usernames and category...");
foreach (var item in userNames)
{
    Console.WriteLine($"{item.UserName} - {item.Category}");
}