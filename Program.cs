using System;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var couldBeAnInt = 93;
            Console.WriteLine($"Hello Gary! {couldBeAnInt}");
            Console.WriteLine($"And show this once more {couldBeAnInt}");
            Console.WriteLine( (new SomeDataEntity()).Info);
        }
    }

    class SomeDataEntity
    {
        private DateTime creationDateTime;
        public SomeDataEntity()
        {
            this.creationDateTime = DateTime.Now;
        }

        public string Info => $"{this.GetType().ToString()} Created: {this.creationDateTime}";
    }
}

