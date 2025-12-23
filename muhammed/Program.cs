using System.Data;
string day,month,year;
Console.WriteLine("Enter Date : ");
DateOnly mydate = DateOnly.Parse(Console.ReadLine());
Console.WriteLine(mydate.DayOfWeek);
Console.WriteLine($"{mydate.DayOfWeek} of monthe {mydate:MMMM} yaer {mydate.Year}");
Console.WriteLine("what is your name ?");
string name = Console.ReadLine();
Console.WriteLine($"name is {name}");

Console.WriteLine("what is your last job ?");
string job = Console.ReadLine();
Console.WriteLine($"his last job is {job}");
Console.WriteLine("what is your current and desired salary ?");
decimal lastSalary, SalaryNow;
lastSalary=decimal.Parse(Console.ReadLine());
SalaryNow = decimal.Parse(Console.ReadLine());
Console.WriteLine($"current salary : {lastSalary} , Desired Salary : {SalaryNow}");
Console.ReadLine();