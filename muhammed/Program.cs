using System.Data;
string day, month, year;
Console.WriteLine("Enter Date : ");
DateOnly mydate = DateOnly.Parse(Console.ReadLine());
Console.WriteLine(mydate.DayOfWeek);
Console.WriteLine($"{mydate.DayOfWeek} of monthe {mydate:MMMM} yaer {mydate.Year}");
//Console.WriteLine("what is your name ?");
//string name = Console.ReadLine();
//Console.WriteLine($"name is {name} it is good name");
//Console.WriteLine("--------------------");
//Console.WriteLine("what is your last job ?");
//string job = Console.ReadLine();
//Console.WriteLine($"his last job is {job}");
//Console.WriteLine("what is your current and desired salary ?");
//decimal lastSalary, SalaryNow;
//lastSalary = decimal.Parse(Console.ReadLine());
//SalaryNow = decimal.Parse(Console.ReadLine());
//Console.WriteLine($"current salary : {lastSalary} , Desired Salary : {SalaryNow}");
//Console.WriteLine("-------------------");
//int x , y;
//x = int.Parse(Console.ReadLine());
//y = int.Parse(Console.ReadLine());
//if (x < y)
//    Console.WriteLine($" No y is {y}" + $" it's begger than x = {x}");
//if (y == x) 
//    Console.WriteLine($"y is {y}" + $" and x is {x} are equal");
//else
//    Console.WriteLine("Y is less than X");
//var result = x < y ? "x is less than y " : "x is bedder than y";
//Console.WriteLine(result);
//var evenOrodd = (y % 2 == 0) ? " even " : "odd";
//Console.WriteLine(evenOrodd);
//string traficlight = "red";
//var massege = traficlight switch
//{
//    "green" => "pass",
//    "yallow" => "slow dawn",
//    "red" => "stop",
//    _ =>"error",
//};
//Console.WriteLine(massege);
//Console.ReadLine();