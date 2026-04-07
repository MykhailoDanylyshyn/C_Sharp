using System;
using ClassLibraryPassport;

class Program
{
    static void Main()
    {
        try
        {
            ForeignPassport forpas = new ForeignPassport("UK", "John", "Doe", "AB", 12345, "Schengen");
            forpas.Show();

            Console.WriteLine();
            Console.WriteLine();

            Passport pas = forpas;
            pas.Show();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}
