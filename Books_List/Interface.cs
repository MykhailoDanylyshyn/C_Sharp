using CSharp.BooksList;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

    static void Main()
    {
        Console.Write("Введи секрет: ");

        string secret = ReadHiddenInput();

        Console.WriteLine("\nГотово.");
        Console.WriteLine($"Довжина введення: {secret.Length}");
    }

    static string ReadHiddenInput()
    {
        StringBuilder sb = new StringBuilder();
        ConsoleKeyInfo key;

        while (true)
        {
            key = Console.ReadKey(true); // true = не показувати символ

            if (key.Key == ConsoleKey.Enter)
                break;

            if (key.Key == ConsoleKey.Backspace && sb.Length > 0)
            {
                sb.Length--;
                continue;
            }

            if (!char.IsControl(key.KeyChar))
            {
                sb.Append(key.KeyChar);
            }
        }

        return sb.ToString();
    }
