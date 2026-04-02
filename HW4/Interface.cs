using CSharp.Date;
using System;
using System.Text;
try
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.InputEncoding = Encoding.UTF8;

    //Date d1 = new();
    //Date d2 = new(1, 1, 2024);
    Date d3 = new();

    //Console.WriteLine("Генеруємо помилку, створюємо дату A.0.-2026");

    //d3.Day = 'A';
    //d3.Month = 0;
    //d3.Year = -2026;
    //d3.PrintDate();

    //Console.WriteLine(d2.DifferenceInDays(d3));

    //d1.PrintDate();
    //d1 = d1.ChangeDateByDays(687000);
    //d1.PrintDate();

    //d3.Day = 29;
    //d3.Month = 3;
    //d3.Year = 2026;

    //Console.WriteLine(d3.Day_Of_Week);

    Console.WriteLine("Генеруємо помилку, додаємо до дати char");
    d3.PrintDate();
    d3 = d3 + 'A';
    d3.PrintDate();
    Console.WriteLine("================");

    //++d3;
    //d3.PrintDate();

    //--d3;
    //d3.PrintDate();

    //Console.WriteLine(d2 == d3 ? "Дати однакові" : "Дати різні");

    //Console.WriteLine($"{d2.Day}.{d2.Month}.{d2.Year}" + (d2 < d3 ? " раніше за " : "пізніше за ") + $"{d3.Day}.{d3.Month}.{d3.Year}");

    //Console.WriteLine(d2 != d3 ? "Дати різні" : "Дати однакові");
}

catch (Exception)
{
    Console.WriteLine("А сьогодні в завтрашній день не всі можуть дивитися. Верніше, дивитися можуть не тільки всі, мало хто може це робити.");
}
