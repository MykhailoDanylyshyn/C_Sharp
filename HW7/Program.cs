using System;
using System.IO;
using System.Text;
using ClassLibrary_HW7;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Оберіть завдання:");
        Console.WriteLine("1 - Заміна слів у файлі");
        Console.WriteLine("2 - Модерація файлу");
        Console.WriteLine("3 - Реверс тексту");
        Console.WriteLine("4 - Аналіз чисел у файлі");
        Console.Write("Ваш вибір: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Task1Run();
                break;

            case "2":
                Task2Run();
                break;

            case "3":
                Task3Run();
                break;

            case "4":
                Task4Run();
                break;

            default:
                Console.WriteLine("Невірний вибір");
                break;
        }
    }

    static void Task1Run()
    {
        Console.WriteLine("Завдання 1");
        Console.WriteLine("=========================================");

        Console.WriteLine("Введіть шлях до файлу: ");
        string filename = Console.ReadLine();

        while (!File.Exists(filename))
        {
            Console.WriteLine("Файл не знайдено, введіть ще раз:");
            filename = Console.ReadLine();
        }

        Console.WriteLine("Введіть слово яке треба замінити: ");
        string word1 = Console.ReadLine();

        Console.WriteLine("Введіть нове слово для заміни: ");
        string word2 = Console.ReadLine();

        try
        {
            int count = Task1.ReplaceWordsInFile(filename, word1, word2);
            Console.WriteLine($"Змінено слів: {count}\n");

            Console.WriteLine("Показати вміст файлу? (yes/no)");
            if (Console.ReadLine()?.ToLower() == "yes")
            {
                Console.WriteLine(File.ReadAllText(filename));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void Task2Run()
    {
        Console.WriteLine("Завдання 2");
        Console.WriteLine("=========================================");

        Console.WriteLine("Введіть шлях до робочого файлу: ");
        string filename = Console.ReadLine();

        while (!File.Exists(filename))
        {
            Console.WriteLine("Файл не знайдено, введіть ще раз:");
            filename = Console.ReadLine();
        }

        Console.WriteLine("Введіть шлях до файлу зі словами для модерування: ");
        string mod_filename = Console.ReadLine();

        while (!File.Exists(mod_filename))
        {
            Console.WriteLine("Файл не знайдено, введіть ще раз:");
            mod_filename = Console.ReadLine();
        }

        try
        {
            Task2.Moderator(filename, mod_filename);
            Console.WriteLine("Модерація завершена!\n");

            Console.WriteLine("Показати вміст файлу? (yes/no)");
            if (Console.ReadLine()?.ToLower() == "yes")
            {
                Console.WriteLine(File.ReadAllText(filename));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void Task3Run()
    {
        Console.WriteLine("Завдання 3");
        Console.WriteLine("=========================================");

        Console.WriteLine("Введіть шлях до файлу для реверсу: ");
        string reverseFile = Console.ReadLine();

        while (!File.Exists(reverseFile))
        {
            Console.WriteLine("Файл не знайдено, введіть ще раз:");
            reverseFile = Console.ReadLine();
        }

        try
        {
            Task3.Reverse(reverseFile);
            Console.WriteLine("Файл успішно перевернуто!");

            Console.WriteLine("Показати вміст нового файлу? (yes/no)");
            if (Console.ReadLine()?.ToLower() == "yes")
            {
                Console.WriteLine(File.ReadAllText(reverseFile + "_reversed.txt"));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void Task4Run()
    {
        Console.WriteLine("Завдання 4");
        Console.WriteLine("=========================================");

        Console.Write("Введіть ім'я файлу для генерації чисел: ");
        string file = Console.ReadLine() +".txt";

        try
        {
            Task4.GenerateFile(file);

            Console.WriteLine("Почати аналіз файлу? (yes/no)");
            if (Console.ReadLine()?.ToLower() == "yes")
            {
                Task4.Analyze(file);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}