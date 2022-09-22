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

Employee aliceInEmployee = new()
{ Name = "Alice", EmployeeCode = "AA123" };

Person aliceInPerson = aliceInEmployee;
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());

//if (aliceInPerson is Employee)
//{
//    WriteLine($"{nameof(aliceInPerson)} IS an Employee");
//    Employee explicitAlice = (Employee)aliceInPerson;
//    // safely do something with explicitAlice
//}

if (aliceInPerson is Employee explicitAlice) //declaration Pattern
{
    WriteLine($"{nameof(aliceInPerson)} IS an Employee");
    // safely do something with explicitAlice
}
