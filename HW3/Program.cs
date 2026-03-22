using System;
using System.Drawing;


class MainClass
{
    static void Main()
    {
        ProcessTask1();
        ProcessTask2();
        ProcessTask3();
    }

    static void ProcessTask1()
    {
        Console.WriteLine("Завдання 1");

        int size = 10;
        int[] intArray = new int[size];
        Random r = new();

        for (int i = 0; i < size; i++)
        {
            intArray[i] = r.Next(0, 5);
            Console.Write("{0,4}", intArray[i]);
        }
        Console.WriteLine();

        int insertPos = 0;

        for (int i = 0; i < size; i++)
        {
            if (intArray[i] != 0)
            {
                intArray[insertPos++] = intArray[i];
            }
        }
        while (insertPos < size)
        {
            intArray[insertPos++] = -1;
        }

        for (int i = 0; i < size; i++)
        {
            Console.Write("{0,4}", intArray[i]);
        }
        Console.WriteLine();
    }

    static void ProcessTask2()
    {
        Console.WriteLine("\nЗавдання 2");

        int size = 7;
        Console.Write("Задайте розмір масиву - непарне ціле число: ");

        try
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Введене число парне. Використовується розмір за замовчуванням: " + size);
            }
            else
            {
                size = input;
            }
        }
        catch
        {
            Console.WriteLine("Невірне число. Використовується розмір за замовчуванням: " + size);
        }

        int[,] intArray = new int[size, size];

        int x_pos = size / 2;
        int y_pos = size / 2;

        intArray[x_pos, y_pos] = 1;
        int value = 2;
        int step = 1;

        while (value <= size * size)
        {
            for (int i = 0; i < step && value <= size * size; i++)
                intArray[--x_pos, y_pos] = value++;

            for (int i = 0; i < step && value <= size * size; i++)
                intArray[x_pos, --y_pos] = value++;
            step++;

            for (int i = 0; i < step && value <= size * size; i++)
                intArray[++x_pos, y_pos] = value++;

            for (int i = 0; i < step && value <= size * size; i++)
                intArray[x_pos, ++y_pos] = value++;
            step++;
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("{0,5}", intArray[i, j]);
            }
            Console.WriteLine("");
        }
    }

    static void ProcessTask3()
    {
        Console.WriteLine("\nЗавдання 3");

        int N = 3;
        int M = 3;

        Console.WriteLine("Задайте кількість рядків масиву: ");
        try
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (input <= 0)
            {
                Console.WriteLine("Невірне число. Використовується кілкість рядків за замовчуванням: " + N + "\n");
            }
            else
            {
                N = input;
            }
        }
        catch
        {
            Console.WriteLine("Невірне число. Використовується кількість рядків за замовчуванням: " + N + "\n");
        }

        Console.WriteLine("Задайте кількість стовпчиків масиву: ");
        try
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (input <= 0)
            {
                Console.WriteLine("Невірне число. Використовується кілкість стовпчиків за замовчуванням: " + M + "\n");
            }
            else
            {
                M = input;
            }
        }
        catch
        {
            Console.WriteLine("Невірне число. Використовується кілкість стовпчиків за замовчуванням: " + M + "\n");
        }

        int[,] intArray = new int[N, M];
        Random r = new();

        Console.WriteLine("Початковий масив: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                intArray[i, j] = r.Next(0, 100);
                Console.Write("{0,4}", intArray[i, j]);
            }
            Console.WriteLine("");
        }

        int shift = 1;
        Console.Write("\nВведіть кількість зсувів: ");
        try
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (input <= 0)
            {
                Console.WriteLine("Кількість зсувів не може бути від'ємною. Встановлена кількість зсувів: " + shift + "\n");
            }
            else
            {
                shift = input % M;
            }
        }
        catch
        {
            Console.WriteLine("Помилка вводу. Встановлена кількість зсувів : " + shift + "\n");
        }

        int direction = 1;
        Console.Write("\nВведіть напрямок (1 - вправо, 2 - вліво): ");
        try
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1 || input == 2)
            {
                direction = input;
            }
            else
            {
                Console.WriteLine("Невідомий напрямок! Напрямок встановлено за замовчуванням: " + direction + "\n");

            }
        }
        catch
        {
            Console.WriteLine("Помилка вводу. Напрямок встановлено за замовчуванням: " + direction + "\n");
        }

        for (int i = 0; i < N; i++)
        {
            for (int s = 0; s < shift; s++)
            {
                if (direction == 1)
                {
                    int last_el = intArray[i, M - 1];
                    for (int j = M - 1; j > 0; j--)
                    {
                        intArray[i, j] = intArray[i, j - 1];
                    }
                    intArray[i, 0] = last_el;
                }

                else
                {
                    int first_el = intArray[i, 0];
                    for (int j = 0; j < M-1; j++)
                    {
                        intArray[i, j] = intArray[i, j + 1];
                    }
                    intArray[i, M - 1] = first_el;
                }
            }


        }

        Console.WriteLine("Після зсуву: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0,4}", intArray[i, j]);
            }
            Console.WriteLine("");
        }
    }
}


