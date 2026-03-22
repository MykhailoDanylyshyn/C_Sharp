class MainClass
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Завдання 1");
            Console.WriteLine("Введіть 5 чисел:");

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0, mul = 1;

            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < min) min = num;
                if (num > max) max = num;

                sum += num;
                mul *= num;
            }

            Console.WriteLine("Мінімум: " + min);
            Console.WriteLine("Максимум: " + max);
            Console.WriteLine("Сума: " + sum);
            Console.WriteLine("Добуток: " + mul);

            //****************************************

            Console.WriteLine("\n\nЗавдання 2");
            Console.WriteLine("Введіть будь-яке число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            int numt = number;

            while (numt > 0)
            {
                int dig = numt % 10;
                reverse = reverse * 10 + dig;
                numt = numt / 10;
            }

            Console.WriteLine("Ваше число: " + number);
            Console.WriteLine("Зворотнє число: " + reverse);

            //****************************************

            Console.WriteLine("\n\nЗавдання 3");
            Console.WriteLine("Будемо малбвати лінію.\nВведіть довжину лінії:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть напрямок лінії: h - горизонтально або v - вертикально");
            char dir = Console.ReadLine().ToLower()[0];

            Console.WriteLine("Введіть символ з якого має складатись лінія: ");
            char sym = Console.ReadLine()[0];

            switch (dir)
            {
                case 'h':
                    for (int i = 0; i < length; i++)
                        Console.Write(sym);
                    break;

                case 'v':
                    for (int i = 0; i < length; i++)
                        Console.WriteLine(sym);
                    break;

                default:
                    Console.WriteLine("Невірний напрямок!");
                    break;
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Невідома помилка: " + ex.Message);
        }
    }
}
