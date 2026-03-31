using System;
using CSharp.BA;

try {
    Console.WriteLine("=== Створення акаунтів ===");

    Account acc1 = new Account("Основний рахунок", 1000);
    Account acc2 = new Account("Накопичувальний рахунок", 500);
    Account acc3 = new Account("Гаманець", 100);

    acc1.ShowInfo();
    acc2.ShowInfo();
    acc3.ShowInfo();

    Console.WriteLine("\n=== Поповнення рахунку ===");
    acc1 = acc1 + 300;
    acc1.ShowInfo();

    Console.WriteLine("\n=== Зняття коштів ===");
    acc2 = acc2 - 200;
    acc2.ShowInfo();

    Console.WriteLine("\n=== Спроба поповнити від'ємною сумою ===");
    try
    {
        acc3 = acc3 + (-50);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Помилка: {ex.Message}");
    }

    Console.WriteLine("\n=== Спроба зняти більше, ніж є на рахунку ===");
    try
    {
        acc3 = acc3 - 500;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Помилка: {ex.Message}");
    }

    Console.WriteLine("\n=== Спроба створити акаунт з від'ємним балансом ===");
    try
    {
        Account badAcc = new Account("Поганий акаунт", -100);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Помилка: {ex.Message}");
    }

    Console.WriteLine("\n=== Кінцевий стан акаунтів ===");
    acc1.ShowInfo();
    acc2.ShowInfo();
    acc3.ShowInfo();
}            
catch (Exception ex)
{
    Console.WriteLine($"Непередбачена помилка: {ex.Message}");
}

        