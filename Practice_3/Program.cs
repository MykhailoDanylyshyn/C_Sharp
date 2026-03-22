using System;
using System.Linq.Expressions;
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

        for (int i = 0; i < input.Length; i++)
        {

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

    static void ProcessTask2()
    {

    }

}


