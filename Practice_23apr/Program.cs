using System;

class Program
{
    static void FirstTask()
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

        Client(ShowCurrentTime);
        Client(ShowCurrentDate);
        Client(ShowCurrentDayOfWeek);
    }

    public delegate int TextProces(string text);

    static int CountVowels(string text)
    {
        string vowels = "aeiouAEIOUаеиіоуяєюїАЕИІОУЯЄЮЇ";
        int count = 0;

        foreach (char c in text)
            if (vowels.IndexOf(c) >= 0)
                count++;

        return count;
    }

    static int CountConsonants(string text)
    {
        string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
                       + "абвгґдеєжзиіїйклмнопрстуфхцчшщьБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬ";
        string vowels = "aeiouAEIOUаеиіоуяєюїАЕИІОУЯЄЮЇ";

        int count = 0;

        foreach (char c in text)
            if (letters.IndexOf(c) >= 0 && vowels.IndexOf(c) < 0)
                count++;

        return count;
    }

    static int GetLength(string text)
    {
        return text.Length;
    }

    static void Client2(TextProces del, string text)
    {
        Console.WriteLine("Результати обробки тексту:\n");

        foreach (TextProces method in del.GetInvocationList())
        {
            int result = method(text);
            Console.WriteLine($"{method.Method.Name,-18} → {result}");
        }
    }

    static void SecondTask()
    {
        TextProces processor = CountVowels;
        processor += CountConsonants;
        processor += GetLength;

        Client2(processor, "Hello World");
    }

    static void Main()
    {
        try
        {
            FirstTask();
            Console.WriteLine("==========================\n");
            SecondTask();
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
    }
}