namespace ClassLibraryHuman
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Ocupation { get; set; }
        public int Salary { get; set; }


        public Human(string name, int age, string ocupation = "", int salary = 0)
        {
            Name = name;
            Age = age;
            Ocupation = ocupation;
            Salary = salary;
        }
        public Human() : this("", 0) { }

        public void Info()
        {
            Console.WriteLine($"Ім'я {Name}.\nВік {Age}");
        }

    }
    public class Builder : Human
    {

        public string Instruments { get; set; }

        public Builder(string name, int age, string ocupation, int salary, string instruments) : base(name, age, ocupation, salary)
        {
            Instruments = instruments;
        }

        new public void Info()
        {
            base.Info();
            Console.WriteLine($"Професія {Ocupation}\nЗаробітня плата {Salary}\nІнструменти {Instruments}\n");
        }


    }
    public class Sailor : Human
    {
        public string Ship { get; set; }

        public Sailor(string name, int age, string ocupation, int salary, string ship) : base(name, age, ocupation, salary)
        {
            Ship = ship;
        }

        new public void Info()
        {
            base.Info();
            Console.WriteLine($"Професія {Ocupation}\nЗаробітня плата {Salary}\nКорабель {Ship}\n");
        }
    }
    public class Pilot : Human
    {
        public string Aircraft { get; set; }

        public Pilot(string name, int age, string ocupation, int salary, string aircraft) : base(name, age, ocupation, salary)
        {
            Aircraft = aircraft;
        }

        new public void Info()
        {
            base.Info();
            Console.WriteLine($"Професія {Ocupation}\nЗаробітня плата {Salary}\nЛітак {Aircraft}\n");
        }
    }
}