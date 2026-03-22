class MainClass
{
    static void Main()
    {
        try
        {
            //Console.WriteLine("Завдання 1\n");
            //Console.WriteLine("Введіть шестизначне число:");
            //int num = Convert.ToInt32 (Console.ReadLine());

            //Console.WriteLine("Введіть першу позицію (від 1 до 6):");
            //int pos1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введіть другу позицію (від 1 до 6):");
            //int pos2 = Convert.ToInt32(Console.ReadLine());

            //if (pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6)
            //{
            //    Console.WriteLine("Помилка: позиції повинні бути від 1 до 6!");
            //    return;
            //}

            //int pow1 = (int)Math.Pow(10, 6 - pos1);
            //int pow2 = (int)Math.Pow(10, 6 - pos2);

            //int num1 = (num / pow1) % 10;
            //int num2 = (num / pow2) % 10;

            //num = num - num1 * pow1 - num2 * pow2;
            //num = num + num1 * pow2 + num2 * pow1;

            //Console.WriteLine("Результат: " + num);


            //****************************************


            //Console.WriteLine("\n\nЗавдання 2");
            //Console.WriteLine("Введіть число:");

            //int num = Convert.ToInt32 (Console.ReadLine());
            //int res = 0;

            //for (int i = 1; i < num; i++)
            //{
            //    if (num % i == 0)
            //        res += i;
            //}
            //Console.WriteLine(num==res ? "Число досконале" : "Число недосконале");


            //****************************************


            Console.WriteLine("\n\nЗавдання 3");
            Console.WriteLine("Введіть число:");

            int num = Convert.ToInt32(Console.ReadLine());
            int max_pow = 1;
            bool res = true;
            int temp = num;

            while (temp >= 10)
            {
                temp /= 10;
                max_pow *= 10;
            }

            while (num > 0) 
            {
                int num_l = num / max_pow;
                int num_r = num % 10;

                if (num_l != num_r)
                {
                    res = false;
                    break;
                }
                
                num = (num % max_pow) / 10;
                max_pow /= 100;
                        
            }

            Console.WriteLine(res ? "Число є поліндромом" : "Число не є поліндромом");
        }

        catch (Exception ex)
        {
            Console.WriteLine("Невідома помилка: " + ex.Message);
        }

    }
}
   
