// using methods;

//RealEstate elmStreet = new()
// {
//     Address = "Elm Street",
//     SquareFeat = 1300,
//     Price = 300000,
// };

// Console.WriteLine(elmStreet.CalculatePricePerSquareFeat());


// #TUPLES
// EX-1
// var values = ("t", 2, "p");
// Console.WriteLine(values.Item1);
// Console.WriteLine(values.Item2);
// Console.WriteLine(values.Item3);

// // Ex-2
// var valuesWithName = (First: "t", Second: 2, Third: "p");
// Console.WriteLine(valuesWithName.First);

// // Ex-3
// (int a, string b, bool c) ReturnTheseValues()
// {
//     return (7, "Eshwar", true);
// }
// (int a, string b, bool c) = ReturnTheseValues();
// Console.WriteLine(ReturnTheseValues());
// Console.WriteLine(a);


// # NULL REFERENCE EXCEPTION / ERROR

// int? value = null;
// string? value2 = null;

// if(value2 is not null)
// {
//     Console.WriteLine(value2.Length);
// }

// Console.WriteLine(value2 ?? "No value!");
// Console.WriteLine(value2 is not null ? "Has value" : "No value");

// down code is for TUPPLES

// using methods;
// RealEstate elmStreet = new("Elm Street");
// elmStreet.Address = "Main Street";

// # STATIC 
using methods;

TimeUtility.printTime();
TimeUtility.printTime();
TimeUtility.printTime();
TimeUtility.printTime();