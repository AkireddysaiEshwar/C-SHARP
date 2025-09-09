// CRUD
// CREATE
//List<int> numNums = [1, 2, 3, 4, 5];

// READ
// foreach(var num in numNums)
// {
//     Console.WriteLine(numNums);
//}

// UPDATE
// This is the fastest.
//numNums.Add(6);
// Insert
// numNums.Insert(0, 0);
// foreach(var num in numNums)
// {
//     Console.WriteLine(num);
// }
// DELETE
//numNums.Remove(1);
//numNums.RemoveAt(0);

// var numNum = numNums.Where((i) => i != 2);
// foreach(var num in numNums)
// {
//     Console.WriteLine(num);
// }


// # RECORDS 
//Person person1 = new("Eshwar", "Varma", new string[1] { "777-234"});
//Person person2 = new("Eshwar", "Varma", new string[1] { "777-234"});

Person person1 = new("Eshwar", "Varma",);
Person person2 = new("Eshwar", "Varma",);

// shallow Immutability
//person1.LastName = "Smiith";
//person1.PhoneNumbers[0] = "222-22222";

// Equalty
// value -1. check the typr 2. check the contents
// Referential - 2. By memory (hex code)
Console.WriteLine(person1 == person2);

// Non destructive Mutation (copy)
Person Person3 = person2 with { LastName = "Brewski" };
Console.WriteLine(Person3.ToString());

public record Person(string FirstName, string LastName);