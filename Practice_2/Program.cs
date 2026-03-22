using System;


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
        int size = 20;
        int[] intArray = new int[size];
        Random r = new();

        for (int i = 0; i < size; i++)
        {
            intArray[i] = r.Next(1,20);
            Console.Write("{0,4}", intArray[i]);
        }

        int odd_counter = 0;
        int even_counter = 0;
        int unique_counter = 0;

        for (int i = 0; i < size; i++)
        {
            if (intArray[i] % 2 == 0)
                even_counter += 1;
            else odd_counter += 1;

            if (Array.IndexOf(intArray, intArray[i]) == Array.LastIndexOf(intArray, intArray[i]))
                unique_counter += 1;
        }

        Console.WriteLine("\nКількість парних: " + even_counter);
        Console.WriteLine("Кількість непарних: " + odd_counter);
        Console.WriteLine("Кількість унікальних: " + unique_counter + "\n");
    }

    static void ProcessTask2()
    {
        int size = 20;
        int[] intArray = new int[size];
        Random r = new();

        for (int i = 0; i < size; i++)
        {
            intArray[i] = r.Next(-30, 10);
            Console.Write("{0,4}", intArray[i]);
        }

        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            if (intArray[i] < 0)
            {
                sum += intArray[i];
            }
            else
                break;
        }

        Console.WriteLine("\nСума чисел до першого від'ємного: " + sum + "\n");
    }

    static void ProcessTask3()
    {
        int size = 5;
        int[,] intArray = new int[size, size];
        Random r = new();

        for (int i = 0; i < size; i++) 
        {
            for (int j = 0; j < size; j++)
            {
                intArray[i,j] = r.Next(-10, 40);
                Console.Write("{0,5}", intArray[i, j]);
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");

        for (int i = 0; i < size; i++)
        {
            int col_sum = 0;
            bool print_flag = true;
            for (int j = 0; j < size; j++)
            {
                if (intArray[j, i] >= 0)
                {
                    col_sum += intArray[j, i];
                }
                else
                { 
                    print_flag = false;
                    break;
                }
            }
            if (print_flag)
                Console.Write("{0,5}", col_sum);
            else
                Console.Write("{0,5}", " ");
        }
        Console.WriteLine("");
    }
}


