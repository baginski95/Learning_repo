﻿using Packt.Shared;
using static System.Console;

Person bob = new Person();

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.BucketList =
 WondersOfTheAncientWorld.HangingGardensOfBabylon
 | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
 arg0: bob.Name,
 arg1: bob.DateOfBirth);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.
StatueOfZeusAtOlympia;
WriteLine(
 format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
 arg0: bob.Name,
 arg1: bob.FavoriteAncientWonder,
 arg2: (int)bob.FavoriteAncientWonder);

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

bob.Children.Add(new Person { Name = "Alfred" }); // C# 3.0 and later
bob.Children.Add(new() { Name = "Zoe" }); // C# 9.0 and later
WriteLine(
 $"{bob.Name} has {bob.Children.Count} children:");
//for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
//{
//    WriteLine($" {bob.Children[childIndex].Name}");
//}
foreach(var child in bob.Children)
{
    WriteLine($" {child.Name}");
}

BankAccount.InterestRate = 0.012M; // store a shared value
BankAccount jonesAccount = new()
{
    AccountName = "Mrs. Jones",
    Balance = 2400
}; // C# 9.0 and later
WriteLine(format: "{0} earned {1:C} interest.",
 arg0: jonesAccount.AccountName,
 arg1: jonesAccount.Balance * BankAccount.InterestRate);
BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
 arg0: gerrierAccount.AccountName,
 arg1: gerrierAccount.Balance * BankAccount.InterestRate);

WriteLine($"{bob.Name} is a {Person.Species}");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

Person blankPerson = new();
WriteLine(format:
 "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
 arg0: blankPerson.Name,
 arg1: blankPerson.HomePlanet,
 arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
 "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
 arg0: gunny.Name,
 arg1: gunny.HomePlanet,
 arg2: gunny.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");
var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

WriteLine(bob.OptionalParameters());

WriteLine(bob.OptionalParameters(
 number: 52.7, command: "Hide!"));

int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

int d = 10;
int e = 20;
WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");

// simplified C# 7.0 or later syntax for the out parameter
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");

Person sam = new Person()
{
    Name = "Sam",
    DateOfBirth = new(1972, 1, 27)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
sam.FavoritePrimaryColor = "Red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

sam.Children.Add(new Person() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

object[] passengers = {
 new FirstClassPassenger { AirMiles = 1_419 },
 new FirstClassPassenger { AirMiles = 16_562 },
 new BusinessClassPassenger(),
 new CoachClassPassenger { CarryOnKG = 25.7 },
 new CoachClassPassenger { CarryOnKG = 0 },
};

foreach (object passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _ => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}
