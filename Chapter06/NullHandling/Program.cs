using Packt.Shared;
using static System.Console;

//int thisCannotBeNull = 4;
////thisCannotBeNull = null; // compile error!
//int? thisCouldBeNull = null;
//WriteLine(thisCouldBeNull);
//WriteLine(thisCouldBeNull.GetValueOrDefault());
//thisCouldBeNull = 7;
//WriteLine(thisCouldBeNull);
//WriteLine(thisCouldBeNull.GetValueOrDefault());
Employee john = new()
{
    Name = "John Jones",
    DateOfBirth = new(year: 1990, month: 7, day: 28)
};
john.WriteToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");
WriteLine(john.ToString());
