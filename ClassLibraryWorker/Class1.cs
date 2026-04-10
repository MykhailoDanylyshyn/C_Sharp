namespace ClassLibraryWorker
{
    public abstract class Worker
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        protected Worker(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        protected string GetFullName()
        {
            return $"{Name} {Surname}";
        }

        public abstract void Print();
    }

    public class President : Worker
    {
        public President(string name, string surname) : base(name, surname) { }

        public override void Print()
        {
            Console.WriteLine($"Мене звати {GetFullName()} і я президент");
        }
    }

    public class Security : Worker
    {
        public Security(string name, string surname) : base(name, surname) { }

        public override void Print()
        {
            Console.WriteLine($"Мене звати {GetFullName()} і я охоронець");
        }
    }

    public class Manager : Worker
    {
        public Manager(string name, string surname) : base(name, surname) { }

        public override void Print()
        {
            Console.WriteLine($"Мене звати {GetFullName()} і я менеджер");
        }
    }

    public class Engineer : Worker
    {
        public Engineer(string name, string surname) : base(name, surname) { }

        public override void Print()
        {
            Console.WriteLine($"Мене звати {GetFullName()} і я інженер");
        }
    }
}