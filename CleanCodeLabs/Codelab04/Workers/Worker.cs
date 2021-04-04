namespace CleanCodeLabs.Codelab04.Workers
{
    public abstract class Worker: IWorker, IRechargeable, IEatable
    {
        protected Worker(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract string Work();
        public virtual string RechargeBatteries() { return null; }
        public virtual string Eat() { return null; }

    }
}