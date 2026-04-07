namespace ClassLibraryPassport
{
    public class Passport
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Series { get; set; }
        public int Number { get; set; }

        public Passport(string country, string name, string surname, string series, int number) 
        { 
            Country = country;
            Name = name;
            Surname = surname;
            Series = series;
            Number = number;
        }

        public Passport() : this(null, null, null, null, 0) { }

        public void Show()
        {
            Console.WriteLine("Country: " + Country);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine($"Document series and number: {Series}{Number}");
        }

    }
    public class ForeignPassport : Passport
    {
        new public string Series { get; set; }
        new public int Number { get; set; }
        public string Visas { get; set; }

        public ForeignPassport (string country, string name, string surname, string series, int number, string visas)
            : base(country,name, surname, series,number) 
        { 
            Series = series;
            Number=number;
            Visas = visas;
        }

        new public void Show()
        { 
            base.Show();
            Console.WriteLine("Visas information: " + Visas);
        }
        
    }
}
