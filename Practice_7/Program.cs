using System;     
using System.IO;  
using System.Text; 

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        try
        {
            Console.WriteLine("Виберіть операцію, яку бажаєте виконати:\n" +
                              "1 - Ввести масив вручну.\n" +
                              "2 - Завантажити масив з файлу.\n" +
                              "0 - Вихід.");

            char command;
            command = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (command)
            {
                case '1':
                    Console.WriteLine("Ви вибрали введення масиву вручну.");

                    Console.Write("Введіть кількість елементів масиву: ");
                    int n = int.Parse(Console.ReadLine());

                    double[] arr = new double[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Введіть елемент [" + i + "]: ");
                        arr[i] = double.Parse(Console.ReadLine());
                    }

                    Console.Write("Введіть шлях до файлу для збереження: ");
                    string savePath = Console.ReadLine();

                    FileStream file1 = new FileStream(savePath, FileMode.Create, FileAccess.Write);

                    BinaryWriter writer = new BinaryWriter(file1);

                    writer.Write(n);

                    for (int i = 0; i < n; i++)
                    {
                        writer.Write(arr[i]);
                    }

                    writer.Close();
                    file1.Close();

                    Console.WriteLine("Масив успішно збережено у файл.");
                    break;

                case '2':
                    Console.WriteLine("Ви вибрали завантаження масиву з файлу.");

                    Console.Write("Введіть шлях до файлу: ");
                    string loadPath = Console.ReadLine();

                    FileStream file2 = new FileStream(loadPath, FileMode.Open, FileAccess.Read);

                    BinaryReader reader = new BinaryReader(file2);

                    int size = reader.ReadInt32();

                    double[] arr2 = new double[size];

                    for (int i = 0; i < size; i++)
                    {
                        arr2[i] = reader.ReadDouble();
                    }

                    reader.Close();
                    file2.Close();

                    Console.WriteLine("Масив, завантажений з файлу:");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(arr2[i] + " ");
                    }
                    Console.WriteLine();
                    break;

                case '0':
                    Console.WriteLine("Вихід з програми.");
                    return;

                default:
                    Console.WriteLine("Невірна команда.");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}