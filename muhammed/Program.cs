int x = 4 , y = 6 ;
if (x < y)
    Console.WriteLine($" No y is {y}" + $" it's begger than x = {x}");
else
    Console.WriteLine("Y is less than X");
var result = x < y ? "x is less than y " : "x is bedder than y";
Console.WriteLine(result);
var evenOrodd = (y % 2 == 0) ? " even " : "odd";
Console.WriteLine(evenOrodd);
Console.ReadLine();