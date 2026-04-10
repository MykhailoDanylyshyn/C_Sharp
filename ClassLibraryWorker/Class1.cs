namespace ClassLibraryWorker
{
    public abstract class Worker
    {
        public abstract void Print();
    }

    public class President : Worker 
    {
        public override void Print() { }
    }
    public class Security : Worker 
    {
        public override void Print() { }
    }
    public class Manager : Worker
    {
        public override void Print() { }
    }
    public class Engineer : Worker
    {
        public override void Print() { }
    }
}
