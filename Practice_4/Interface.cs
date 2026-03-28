using CSharp.City;
using CSharp.Employee;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

City Kyiv = new();
Kyiv.PrintData();

Kyiv.InputData();
Kyiv.PrintData();

Employee emp1 = new Employee();
emp1.PrintData();

emp1.InputData();
emp1.PrintData();

