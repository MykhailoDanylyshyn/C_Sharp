using System;
namespace HW5 
{
    struct Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
        }

        public int Denominator
        {
            get { return denominator; }
        }

        public Fraction(int n, int d)
        {
            numerator = n;

            if (d == 0)
            {
                denominator = 1;
                Console.WriteLine("Знаменник не може бути 0. Встановлено 1.");
            }
            else
            {
                denominator = d;
            }

            Reduce();
        }

        private int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public void Reduce()
        {
            int gcd = GCD(numerator, denominator);

            if (gcd != 0)
            {
                numerator /= gcd;
                denominator /= gcd;
            }

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            if (numerator == 0)
            {
                denominator = 1;
            }
        }

        public void Show()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }
    }

    static class FractionCalculator
    {
        public static Fraction Add(Fraction a, Fraction b)
        {
            int num = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int den = a.Denominator * b.Denominator;
            return new Fraction(num, den);
        }

        public static Fraction Subtract(Fraction a, Fraction b)
        {
            int num = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int den = a.Denominator * b.Denominator;
            return new Fraction(num, den);
        }

        public static Fraction Multiply(Fraction a, Fraction b)
        {
            int num = a.Numerator * b.Numerator;
            int den = a.Denominator * b.Denominator;
            return new Fraction(num, den);
        }

        public static Fraction Divide(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
            {
                Console.WriteLine("Помилка: ділення на дріб з чисельником 0 неможливе.");
                return new Fraction(0, 1);
            }

            int num = a.Numerator * b.Denominator;
            int den = a.Denominator * b.Numerator;
            return new Fraction(num, den);
        }
    }
}


