using CSharp.Date;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Date d1 = new();
Date d2 = new(1,1,2024);
Date d3 = new();

d3.Day = 28;
d3.Month = 3;
d3.Year = 2026;

d2.DifferenceInDays(d3);

d1.PrintDate();
d1.ChangeDateByDays(687000);
d1.PrintDate();

d1.ChangeDateByDays(-11);
d1.PrintDate();

d3.Day = 29;
d3.Month = 3;
d3.Year = 2026;

Console.WriteLine(d3.Day_Of_Week);