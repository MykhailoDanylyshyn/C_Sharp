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
                int maxDay = 31;

                if (month == 2)
                    maxDay = IsLeapYear(this.year) ? 29 : 28;
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                    maxDay = 30;
                if (value < 1 || value > maxDay)
                    throw new ArgumentException("Некоректний день");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Некоректний місяць");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Некоректний рік");
                year = value;
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
            try
            {
                Year = year;
                Month = month;
                Day = day;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");

            }
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
            {
                totalDays += IsLeapYear(y) ? 366 : 365;
            }

            for (int m = 1; m < Month; m++)
            {
                totalDays += DaysInMonth(m, Year);
            }

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


        public void DifferenceInDays(Date other)
        {
            int days1 = this.ToTotalDays();
            int days2 = other.ToTotalDays();
            int diff = Math.Abs(days1 - days2);

            Console.WriteLine($"Різницяe між датами у днях: {diff}");
        }

        public void ChangeDateByDays(int days)
        {
            int totalDays = ToTotalDays();
            totalDays += days;

            if (totalDays < 1)
                throw new ArgumentException("Нова дата некоректна");

            FromTotalDays(totalDays);
        }


    }
}
