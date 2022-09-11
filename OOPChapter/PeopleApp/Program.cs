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