using System;

namespace CSharp.Date
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                

                try
                {
                    int maxDay = DaysInMonth(month, year);

                    if (value < 1 || value > maxDay)
                        throw new ArgumentException("Некоректний день");

                    day = value;
                }
                catch (ArgumentException ex)
                {
                    day = 1;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"Встановлене значення дня: 1");
                }
            }
        }

        public string Day_Of_Week
        {
            get
            {
                int dayIndex = this.ToTotalDays() % 7;

                return dayIndex switch
                {
                    1 => "Monday",
                    2 => "Tuesday",
                    3 => "Wednesday",
                    4 => "Thursday",
                    5 => "Friday",
                    6 => "Saturday",
                    0 => "Sunday",
                    _ => ""
                };
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                try
                {
                    if (value < 1 || value > 12)
                        throw new ArgumentException("Некоректний місяць");

                    if (day > 0 && year > 0 && day > DaysInMonth(value, year))
                        throw new ArgumentException("Поточний день не існує в новому місяці");

                    month = value;
                }
                catch (ArgumentException ex)
                {
                    month = 1;
                    Console.WriteLine( ex.Message);
                    Console.WriteLine($"Встановлене значення місяця: 1");
                }
            }
            
        }

        public int Year
        {
            get { return year; }
            set
            {
                try
                {
                    if (value < 1)
                        throw new ArgumentException("Некоректний рік");

                    if (day > 0 && month > 0 && day > DaysInMonth(month, value))
                        throw new ArgumentException("Поточний день не існує в новому році");

                    year = value;
                }
                catch (ArgumentException ex)
                {
                    year = 1;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"Встановлене значення року: 1");
                }
            }
        }

        public Date()
        {
            Year = 1;
            Month = 1;
            Day = 1;
        }

        public Date(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public void PrintDate()
        {
            Console.WriteLine($"{day:D2}.{month:D2}.{year:D4}");
        }

        private bool IsLeapYear(int y)
        {
            return (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0);
        }

        private int DaysInMonth(int m, int y)
        {
            if (m == 2)
                return IsLeapYear(y) ? 29 : 28;
            else if (m == 4 || m == 6 || m == 9 || m == 11)
                return 30;
            else
                return 31;
        }

        private int ToTotalDays()
        {
            int totalDays = 0;

            for (int y = 1; y < Year; y++)
                totalDays += IsLeapYear(y) ? 366 : 365;

            for (int m = 1; m < Month; m++)
                totalDays += DaysInMonth(m, Year);

            totalDays += Day;

            return totalDays;
        }

        private void FromTotalDays(int totalDays)
        {
            int y = 1;

            while (true)
            {
                int daysInYear = IsLeapYear(y) ? 366 : 365;

                if (totalDays > daysInYear)
                {
                    totalDays -= daysInYear;
                    y++;
                }
                else
                    break;
            }

            int m = 1;

            while (true)
            {
                int daysInMonth = DaysInMonth(m, y);

                if (totalDays > daysInMonth)
                {
                    totalDays -= daysInMonth;
                    m++;
                }
                else
                    break;
            }

            Year = y;
            Month = m;
            Day = totalDays;
        }

        public int DifferenceInDays(Date other)
        {
            try
            {
                return Math.Abs(this.ToTotalDays() - other.ToTotalDays());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0; }
            
        }

        public Date ChangeDateByDays(int days)
        {
            try {
                Date result = new();

                int totalDays = ToTotalDays();
                totalDays += days;

                if (totalDays < 1)
                    throw new ArgumentException("Нова дата некоректна");

                result.FromTotalDays(totalDays);
                return result;
            }
            catch (ArgumentException aex) 
            {

                Console.WriteLine(aex.Message);
                return this;
            }
        }

        public static  int operator -(Date a, Date b)
        {
            {
                try
                { 
                    return a.DifferenceInDays(b);
                }
                catch (Exception)
                {
                    Console.WriteLine("Сталась помилка! Дія не виконана.");
                }
                return 0;
            }
            
        }

        public static Date operator +(Date a, int d)
        {
            try 
            {
                return a.ChangeDateByDays(d);
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }
                return a;
        }
        public static Date operator +(Date a, char c)
        {
            throw new ArgumentException("Не можна додавати символ до дати");
        }

        public static Date operator ++(Date a)
        { 
            return a.ChangeDateByDays(1);
        }
        public static Date operator --(Date a)
        { 
            return a.ChangeDateByDays(-1);
        }

        public static bool operator >(Date a, Date b)
        { 
        if (a.ToTotalDays() > b.ToTotalDays())
                return true;
        else 
                return false;
        }
        public static bool operator <(Date a, Date b)
        { 
        if (a.ToTotalDays() < b.ToTotalDays())
                return true;
        else 
                return false;
        }

        public static bool operator ==(Date a, Date b)
        { 
        if (a.day == b.day && a.month == b.month && a.year == b.year)
                return true;
        else
                return false;
        }
        public static bool operator !=(Date a, Date b)
        { 
        if (a.day != b.day || a.month != b.month || a.year != b.year)
                return true;
        else
                return false;
        }

    }
}