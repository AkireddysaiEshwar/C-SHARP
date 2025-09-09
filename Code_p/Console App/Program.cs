// Console.WriteLine("Hello world!");
// Console.WriteLine("Praise the great leader... BILL GATES!");

// Variables Assignment
// string BillGates = "He is richest person!";
// Console.WriteLine(BillGates);

// int Number = 7;
// Console.WriteLine(Number);

// using System.Text;

// var Char = "Myself Eshwar";
// Console.WriteLine(Char);

// Create Read Update Delete
// CRUD

// # CREATE
//string petFish = "Pupper Fish";

// Concatenation
//petFish = "porcupine" + petFish;

// Template Literal
// Console.WriteLine($"I AM BUYING {petFish}. YOU CANNOT STOP ME!!!");
// Console.Write(petFish);


// # UPDATE
// PetFish[0] = "P";
// string newPetFish = petFish.Replace("porcupine", "blue dot");
// Console.WriteLine(newPetFish);

// DELETE
// String builder
// StringBuilder newCrustacean = new StringBuilder();
// newCrustacean.Append("Fiddler Crab");
// Console.WriteLine(newCrustacean);
// newCrustacean.Remove(0, 8);
// Console.WriteLine(newCrustacean);

// ARRAYS 
// CRUD 

// Create 
//string[] faverateRats = ["Fancy Rat", "White Rat", "Black Rat", "Brown Rat"];

// Read
// Console.WriteLine(faverateRats);

//foreach(var rat in faverateRats)
//{
//    Console.WriteLine(rat);
//}

// Update
//faverateRats[0] = "FANCY RAT";
// LINQ = "Update Array linq"

//var newFaverateRat = faverateRats.Where((e) => e.StartsWith('B'));

//foreach(var rat in newFaverateRat)
// {
//     Console.WriteLine(rat);
// }

// DELETE

// COUNTER
// for(var i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }

// string[] fevariateAnimals = ["Lion", "Tiger", "Deear", "Horse"];

// for(var i = 0; i < fevariateAnimals.Length; i++)
// {
//     Console.WriteLine(fevariateAnimals[i]);
//    Console.WriteLine(fevariateAnimals[1]);
// }

// foreach (var band in fevariateAnimals)
// {
//     Console.WriteLine(band);
// }

//fevariateAnimals.ToList().ForEach((i) => {
//    Console.WriteLine("ForEach: " + 1);
//});

//Array.ForEach(fevariateAnimals, e => Console.WriteLine("Array.ForEach: " + e));

// #IF / ELESE
//if(false)

// if(true)
// {
//     Console.WriteLine("This code will always run!");
// }

// COMPARISON CHECKER

// var favoriteAuthor = "Friedrich Nietzche";
// if(favoriteAuthor == "Friedrich Nietzche")
// {
//     Console.WriteLine("You are probably insane!");
// }

// if(2 > 1)
// {
//     Console.WriteLine("Two is greater than one!");
// }


// var golf = false;
// var running = false;

// if((running == true) && (golf == true))
// {
//     Console.WriteLine("Today was a great day!");
// }
// else if((running == true) || (golf == true))
// {
//     Console.WriteLine("Today was a decent day!");
// }
// else
// {
//     Console.WriteLine("I did nothing..!");
// }


// var aquariumStoreInventory = "blue tang";

// if(aquariumStoreInventory == "puffer fish")
// {
//     Console.WriteLine("I will buy puffer fish!");
// }
// else if(aquariumStoreInventory == "clown fish")
// {
//     Console.WriteLine("I will buy clown fish!");
// }
// else 
// {
//     Console.WriteLine("I will not buy anything!");
// }

// <>
// var fishTankPrice = 999;

// if(fishTankPrice <= 1000)
// {
//     Console.WriteLine("Buy Tank");
// }
// else
// {
//     Console.WriteLine("Don'T Buy");
// }

// // checking 
// string aquariumFish = "puffer Fish";

// if(aquariumFish is string)
// {
//     Console.WriteLine("Aquarium Fish is a string");
// }

// ENUM

// Console.WriteLine((int)Warning.CodeYellow);

// var status = Warning.CodeYellow;

// if(status == Warning.CodeYellow)
// {
//     Console.WriteLine("CODE YELLOW");
// }

// enum Warning
// {
//     CodeRed,
//     CodeBlue,
//     CodeYellow
// }

// SWITCH STATEMENTS

// using System.Net.NetworkInformation;

// var preHistoricFish = "Cockerelitte";

// switch (preHistoricFish)
// {
//     case "Heliobatics":
//         Console.WriteLine("Heliobaatis!");
//         break;
//     case "Cockerelitte":
//         Console.WriteLine("Cockerelitte");
//         break;
//     default:
//         Console.WriteLine("Nothing matches!");
//         break;
// }

// var result = preHistoricFish switch
// {
//     "Heliobatis" => "Helobatis",
//     "Cockerlittle" => "Cockerlitte",
//     _ => "No match!"
// };

// Console.WriteLine("This is a " + result);

// Pinger
// using System.Net.NetworkInformation;

// Ping p1 = new Ping();
// PingReply PR = p1.Send("8.8.8.8");

// while (PR.Status.ToString() == "Success")
// {
//     Console.WriteLine(PR.Status.ToString() + "!");
//     PR = p1.Send("8.8.8.8");
//     Console.WriteLine("waiting ten seconds for next request");
//     Thread.Sleep(10000);
// }

// // CRUD
// // CREATE
// using ConsoleApp;
// Rat wolfRat = new Rat();
// Rat fancyRat = new Rat();

// wolfRat.Name = "Wolf Rat";
// wolfRat.Number = 1000;
// wolfRat.IsRadioactive = false;

// fancyRat.Name = "Fancy Rat";
// fancyRat.Number = 500;
// fancyRat.IsRadioactive = true;

// // Read
// Console.WriteLine(wolfRat.Name);
// Console.WriteLine(wolfRat.Number);
// Console.WriteLine(wolfRat.IsRadioactive);
// Console.WriteLine(fancyRat.Name);
// Console.WriteLine(fancyRat.Number);
// Console.WriteLine(fancyRat.IsRadioactive);

// // UPDATE
// wolfRat.Name = "WOLF RAT";
// fancyRat.Name = "FANCY RAT";

// Console.WriteLine(wolfRat.Name);
// Console.WriteLine(fancyRat.Name);

// // DELETE 
// wolfRat.Name = "";
// fancyRat.Name = "";

// Console.WriteLine(wolfRat.Name);
// Console.WriteLine(fancyRat.Name);