using Packt.Shared;
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
