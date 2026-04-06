using System;
using System.Collections.Generic;
using System.Text;
using HW5;


Fraction fr1 = new Fraction(10, 20); // 1/2
Fraction fr2 = new Fraction(15, 25); // 3/5

Console.Write("Перший дріб: ");
fr1.Show();

Console.Write("Другий дріб: ");
fr2.Show();

Fraction sum = FractionCalculator.Add(fr1, fr2);
Console.Write("Сума: ");
sum.Show();

Fraction diff = FractionCalculator.Subtract(fr1, fr2);
Console.Write("Різниця: ");
diff.Show();

Fraction mult = FractionCalculator.Multiply(fr1, fr2);
Console.Write("Добуток: ");
mult.Show();

Fraction div = FractionCalculator.Divide(fr1, fr2);
Console.Write("Частка: ");
div.Show();
