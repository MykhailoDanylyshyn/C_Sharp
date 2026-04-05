using System;     
using System.IO;  
using System.Text;

namespace Practice_7
{
    class Program
    {
        public void Run()
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

    class Program_2
    {
        public void Run()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;

                int size = 10000;
                int odd_size = 0;
                int even_size = 0;

                int[] arr = new int[size];
                Random rnd = new Random();

                // Fill array + count
                for (int i = 0; i < size; i++)
                {
                    arr[i] = rnd.Next(0, 100);

                    if (arr[i] % 2 == 0)
                        even_size++;
                    else
                        odd_size++;
                }

                // Create arrays AFTER counting
                int[] odd_arr = new int[odd_size];
                int[] even_arr = new int[even_size];

                // Fill arrays
                for (int i = 0, j = 0, k = 0; i < size; i++)
                {
                    if (arr[i] % 2 == 0)
                        even_arr[j++] = arr[i];
                    else
                        odd_arr[k++] = arr[i];
                }

                // Save odd numbers
                string savePath = "D:\\Programming\\C#\\ConsoleApp1\\Practice_7\\odd_array.txt";
                using (BinaryWriter writer = new BinaryWriter(File.Open(savePath, FileMode.Create)))
                {
                    writer.Write(odd_size);
                    for (int i = 0; i < odd_size; i++)
                    {
                        writer.Write(odd_arr[i]);
                    }
                }

                Console.WriteLine($"До файлу {savePath} записано {odd_size} чисел.");

                // Save even numbers
                savePath = "D:\\Programming\\C#\\ConsoleApp1\\Practice_7\\even_array.txt";
                using (BinaryWriter writer = new BinaryWriter(File.Open(savePath, FileMode.Create)))
                {
                    writer.Write(even_size);
                    for (int i = 0; i < even_size; i++)
                    {
                        writer.Write(even_arr[i]);
                    }
                }

                Console.WriteLine($"До файлу {savePath} записано {even_size} чисел.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Program_3
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Введіть шлях до файлу: ");
                string filename = Console.ReadLine();
                StreamReader sr = new StreamReader(filename, Encoding.Default);
                string text = sr.ReadToEnd();
                sr.Close();

                int sentences = 0;
                int upper = 0;
                int lower = 0;
                int vowels = 0;
                int consonants = 0;
                int words = 0;

                string vowelLetters = "аеєиіїоуюяAEЄИІЇОУЮЯaeiouy";

                foreach (char c in text)
                {
                    if (c == '.' || c == '!' || c == '?')
                        sentences++;
                }

                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        if (char.IsUpper(c))
                            upper++;
                        else
                            lower++;

                        if (vowelLetters.Contains(c))
                            vowels++;
                        else
                            consonants++;
                    }
                }

                words = text.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';' },StringSplitOptions.RemoveEmptyEntries).Length;

                Console.WriteLine($"Речень: {sentences}");
                Console.WriteLine($"Великих літер: {upper}");
                Console.WriteLine($"Маленьких літер: {lower}");
                Console.WriteLine($"Голосних: {vowels}");
                Console.WriteLine($"Приголосних: {consonants}");
                Console.WriteLine($"Слів: {words}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
