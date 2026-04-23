using System;
class Program
{
    static void ShowCurrentTime()
    {
        Console.WriteLine("Поточний час: " + DateTime.Now.ToLongTimeString());
    }

    static void ShowCurrentDate()
    {
        Console.WriteLine("Поточна дата: " + DateTime.Now.ToShortDateString());
    }

    static void ShowCurrentDayOfWeek()
    {
        Console.WriteLine("Сьогодні: " + DateTime.Now.DayOfWeek);
    }

    static void Client(Action method)
    {
        method();
    }

    static void Main()
    {
        Client(ShowCurrentTime);
        Client(ShowCurrentDate);
        Client(ShowCurrentDayOfWeek);
    }
}