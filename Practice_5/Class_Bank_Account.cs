using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.BA
{
    class Account
    {
        public string Name { get; set; }
        public float Balance { get; set; }

        public Account()
        {
            Name = string.Empty;
            Balance = 0;
        }

        public Account(string name, float balance)
        {
            if (balance < 0)
                throw new ArgumentOutOfRangeException(nameof(balance), "Баланс не може бути від'ємним.");

            Name = name;
            Balance = balance;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Назва аккаунту: {Name}. Поточний баланс: {Balance}");
        }

        public static Account operator +(Account a, int cash)
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a));

            if (cash < 0)
                throw new ArgumentOutOfRangeException(nameof(cash), "Сума поповнення не може бути від'ємною.");

            a.Balance += cash;
            return a;
        }

        public static Account operator -(Account a, int cash)
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a));

            if (cash < 0)
                throw new ArgumentOutOfRangeException(nameof(cash), "Сума зняття не може бути від'ємною.");

            if (a.Balance - cash < 0)
                throw new InvalidOperationException("Баланс не може бути від'ємним!");

            a.Balance -= cash;
            return a;
        }
    }
}
