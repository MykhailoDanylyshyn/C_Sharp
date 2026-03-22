class MainClass
{
    static void Main()
    {
        try
        {
            //Console.WriteLine("Завдання 1");
            //Console.WriteLine("Введіть число:");

            //int num = Convert.ToInt32(Console.ReadLine());
            //int original = num;

            //int max_pow = 1;
            //int num_dig = 1;
            //int res = 0;
            //int temp = num;

            //while (temp >= 10)
            //{
            //    temp /= 10;
            //    max_pow *= 10;
            //    num_dig++;
            //}

            //temp = num;


            //while (temp > 0)
            //{
            //    int n = temp / max_pow;
            //    temp = temp - n * max_pow;
            //    res += (int)Math.Pow(n, num_dig);
            //    max_pow /= 10;
            //}

            //Console.WriteLine("Число " + num + (res == original ? " є числом Армстронга" : " не є числом Армстронга"));


            //****************************************


            Console.WriteLine("\n\nЗавдання 2");
            Console.WriteLine("Введіть 15 чисел, для вводу використовуйте Enter: ");

            int count = 0;
            int prev_num = 0;

            int chain_length = 0;
            int max_length = 0;

            int current_start = 0;
            int best_start = 0;

            while (count < 15)
            {
                Console.WriteLine("Введіть число: ");
                int cur_num = Convert.ToInt32(Console.ReadLine());

                if (count == 0)
                {
                    prev_num = cur_num;
                    chain_length = 1;
                    max_length = 1;
                    current_start = 0;
                    best_start = 0;
                }
                else
                {
                    if (prev_num <= cur_num)
                    {
                        chain_length++;
                    }
                    else
                    {
                        chain_length = 1;
                        current_start = count;
                    }

                    if (chain_length > max_length)
                    {
                        max_length = chain_length;
                        best_start = current_start;
                    }

                    prev_num = cur_num;
                }

                count++;
            }

            Console.WriteLine("Максимальна довжина послідовності: " + max_length);
            Console.WriteLine("Послідовність починається з індексу: " + best_start);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Невідома помилка: " + ex.Message);
        }
    }
}