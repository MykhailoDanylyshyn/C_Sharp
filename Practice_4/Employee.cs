using System;

namespace CSharp.Employee

{
    class Employee
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Responsibilities { get; set; }

        public Employee()
        {
            FullName = "NoName";
            BirthDate = DateTime.Now;
            Phone = "Unknown";
            Email = "Unknown";
            Position = "Unknown";
            Responsibilities = "None";
        }

        public Employee(string fullName, DateTime birthDate, string phone,
                        string email, string position, string responsibilities)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Position = position;
            Responsibilities = responsibilities;
        }

        public void InputData()
        {
            Console.Write("Enter full name: ");
            FullName = Console.ReadLine();

            Console.Write("Enter birth date (yyyy-mm-dd): ");

            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                BirthDate = date;
            }
            else
            {
                Console.WriteLine("Invalid date! Try again.");
            }

            Console.Write("Enter phone: ");
            Phone = Console.ReadLine();

            Console.Write("Enter email: ");
            Email = Console.ReadLine();

            Console.Write("Enter position: ");
            Position = Console.ReadLine();

            Console.Write("Enter responsibilities: ");
            Responsibilities = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine("\n--- Employee Info ---");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Responsibilities: {Responsibilities}");
        }
    }

}
