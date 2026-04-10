namespace ClassLibraryCourse
{
    public class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public Course(string name, int duration ) 
        { 
            Name = name;
            Duration = duration;
        }

        public Course() : this(null, 0) { }

        public override string ToString() 
        {
            return $"Курс {Name}. Тривалість курсу {Duration} міс.";
        }
    }

    public class OnlineCourse : Course 
    {
        public string Platform { get; set; }

        public OnlineCourse (string name, int duration,bool isOnline) : base(name, duration)
        {
            if (isOnline)
            {
                Platform = "Online";
            }
            else 
            {
                Platform = "Offline";
            }
        }

        public override string ToString()
        {
            return $"Курс {Name}({Platform}). Тривалість курсу {Duration} міс.";
        }
    }
}
