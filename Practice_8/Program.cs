using System;
using ClassLibraryPassport;
using ClassLibraryHuman;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Перше завдання"+ "\n========================================\n");

            ForeignPassport forpas = new ForeignPassport("UK", "John", "Doe", "AB", 12345, "Schengen");
            forpas.Show();

            Console.WriteLine();

            Passport pas = forpas;
            pas.Show();

            Console.WriteLine("\nДруге завдання"+"\n========================================\n");

            Builder b = new Builder("Іван", 35, "Будівельник", 20000, "Молоток");
            b.Info();

            Sailor s = new Sailor("Петро", 40, "Моряк", 25000, "Чорна перлина");
            s.Info();

            Pilot p = new Pilot("Олег", 30, "Пілот", 50000, "Boeing 737");
            p.Info();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}
