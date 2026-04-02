using System;

namespace CSharp.Employee

{
    class Employee
    {
        public string FullName { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Responsibilities { get; set; }
        public float Salary { get; set; }

        public Employee()
        {
            FullName = "NoName";
            BirthDate = "01.01.1990";
            Phone = "Unknown";
            Email = "Unknown";
            Position = "Unknown";
            Responsibilities = "None";
            Salary = 0;
        }

        public Employee(string fullName, string birthDate, string phone,
                        string email, string position, string responsibilities,float salary)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Position = position;
            Responsibilities = responsibilities;
            Salary = salary;
        }

        public static Employee operator +(Employee emp1, float value)
        {
            Employee result = new()
            {
                FullName = emp1.FullName,
                BirthDate = emp1.BirthDate,
                Phone = emp1.Phone,
                Email = emp1.Email,
                Position = emp1.Position,
                Responsibilities = emp1.Responsibilities,
                Salary = emp1.Salary + value
            };
            return result;
        }

        public static Employee operator -(Employee emp1, float value)
        {
            Employee result = new()
            {
                FullName = emp1.FullName,
                BirthDate = emp1.BirthDate,
                Phone = emp1.Phone,
                Email = emp1.Email,
                Position = emp1.Position,
                Responsibilities = emp1.Responsibilities,
                Salary = emp1.Salary - value
            };
            return result;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.Salary == emp2.Salary)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.Salary != emp2.Salary)
                return true;
            else
                return false;
        }



        public void InputData()
        {
            Console.Write("Enter full name: ");
            FullName = Console.ReadLine();

            Console.Write("Enter birthday date: ");
            FullName = Console.ReadLine();

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
            Console.WriteLine($"Birth Date: {BirthDate}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Responsibilities: {Responsibilities}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine();
        }

        public (string, string,double) Salary_Calculate(double per_hour, int days) // фіксована ставка
        {
            try
            {
                (string, string, double) cal_salary = ("Фіксована ставка", FullName, Math.Round(per_hour * days * 8,2));
                return cal_salary;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неочікувана помилка!");
                return ("Помилка при обчисленні", FullName, 0);
            }
            
        }
        public (string, string, double) Salary_Calculate(double per_hour, double hours) // за годинним тарифом
        {
            try
            {
                (string, string, double) cal_salary = ("За годинним тарифом", FullName, Math.Round( per_hour * hours,2));
                return cal_salary;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неочікувана помилка!");
                return ("Помилка при обчисленні", FullName, 0);
            }

        }
        public (string, string, double) Salary_Calculate(double per_hour, int hours, int days, double bonus_percent) // "з урахуванням премій
        {
            try
            {
                (string, string, double) cal_salary = ("З урахуванням премій", FullName, Math.Round(per_hour * hours * days * (1+bonus_percent/100.0),2));
                
                return cal_salary;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неочікувана помилка!");
                return ("Помилка при обчисленні", FullName, 0);
            }
        }
          
    }

}
