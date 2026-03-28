using System;

namespace CSharp.City
{
    class City
    {
        private string name;
        private int population;
        private string country;
        private string districts;
        private string code;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                    name = value;
            }
        }

        public int Population
        {
            get { return population; }
            set
            {
                if (value > 0)
                    population = value;
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                if (value != "")
                    country = value;
            }
        }

        public string Districts
        {
            get { return districts; }
            set
            {
                if (value != "")
                    districts = value;
            }
        }

        public string Code
        {
            get { return code; }
            set
            {
                bool allnums = true;
                foreach (char c in value)
                {
                    if (!Char.IsNumber(c))
                        allnums = false;
                }

                if (value.Length >= 3 && value.Length < 5 && allnums)
                    code = value;
            }
        }

        public City(string Name, int Population, string Country, string Districts, string Code)
        {
            this.Name = Name;
            this.Population = Population;
            this.Country = Country;
            this.Districts = Districts;
            this.Code = Code;
        }

        public City() : this("NoName", 1, "Unknown", "None", "0000")
        {
        }

        public void PrintData()
        {
            Console.WriteLine($"{name}, {country}, {districts}, {code}. Population is {population}");
        }

        public void InputData()
        {
            Console.Write("Enter city name: ");
            Name = Console.ReadLine();

            Console.Write("Enter population: ");
            Population = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter country: ");
            Country = Console.ReadLine();

            Console.Write("Enter districts: ");
            Districts = Console.ReadLine();

            Console.Write("Enter city code: ");
            Code = Console.ReadLine();
        }
    }
}