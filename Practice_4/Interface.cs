using CSharp.City;
using CSharp.Employee;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Employee emp1 = new();
Employee emp2 = new();
emp1.PrintData();

emp1 = emp1 + 3000;
emp1.PrintData();

emp1 = emp1 - 1500;
emp1.PrintData();

emp2.Salary = 4000;
Console.WriteLine(emp1 == emp2 ? "Зарплатні рівні" : "Зарплатні нерівні");

emp1.Salary = 4000;
Console.WriteLine(emp1 == emp2 ? "Зарплатні рівні" : "Зарплатні нерівні");

