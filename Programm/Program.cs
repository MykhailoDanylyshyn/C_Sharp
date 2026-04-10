using ClassLibraryCourse;
using ClassLibraryWorker;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Перше завдання" + "\n========================================\n");

            Course course = new Course("C++", 18);
            Course course_2 = new Course("Python", 6);
            OnlineCourse course_3 = new OnlineCourse("C#", 18, true);

            Console.WriteLine(course);
            Console.WriteLine(course_2);
            Console.WriteLine(course_3);

            Console.WriteLine("\nДруге завдання" + "\n========================================\n");

            Worker w1 = new President("Іван", "Петренко");
            Worker w2 = new Engineer("Олег", "Коваль");
            Worker w3 = new Manager("Анна", "Шевченко");
            Worker w4 = new Security("Петро", "Сидоренко");

            w1.Print();
            w2.Print();
            w3.Print();
            w4.Print();

        }


        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


