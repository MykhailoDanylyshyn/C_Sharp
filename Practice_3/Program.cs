using System;

class MainClass
{
    static void Main()
    {
        ProcessTask1();
        ProcessTask2();
    }

    static void ProcessTask1()
    {
        
        Console.WriteLine("Введіть арифметичний вираз: ");
        string input = Console.ReadLine();

        int result = 0;
        string number = "";
        char op = '+';
        try
        {

            for (int i = 0; i < input.Length; i++)
        {
                if (!char.IsDigit(input[i]) && input[i] != '+' && input[i] != '-')
                    throw new Exception("Дозволені тільки цифри, + і -");

                if (char.IsDigit(input[i]))
                {
                    number += input[i];
                }
                else if (input[i] == '+' || input[i] == '-')
                {
                    if (number == "")
                    {
                        op = input[i];
                        continue;
                    }

                    if (op == '+')
                        result += int.Parse(number);
                    else
                        result -= int.Parse(number);

                    number = "";
                    op = input[i];
                }
        }

        if (number != "")
        {
            if (op == '+')
                result += int.Parse(number);
            else
                result -= int.Parse(number);
        }

            Console.WriteLine("Результат: " + result);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка: " + ex.Message);
        }

    }

    static void ProcessTask2()
    {
        try
        {
            Console.Write("Введіть текст: ");
            string input = Console.ReadLine();

            string output = "";
            bool upCase = true;

            foreach (char c in input)
            {
                if (upCase && char.IsLetter(c))
                {
                    output += char.ToUpper(c);
                    upCase = false;
                }
                else
                {
                    output += c;
                }

                if (c == '.' || c == '!' || c == '?')
                {
                    upCase = true;
                }
            }

            Console.WriteLine("Відформатований текст:");
            Console.WriteLine(output);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка: " + ex.Message);
        }
    }
}



