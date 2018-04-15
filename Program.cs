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
            var oneSomeDataEntity=new SomeDataEntity(23);
            Console.WriteLine( oneSomeDataEntity.Info);
        }
    }

    class SomeDataEntity
    {

        public SomeDataEntity(int anyCount)
        {
            this.AnyCount = anyCount;
            this.creationDateTime = DateTime.Now;
        }

        private DateTime creationDateTime;
        public int AnyCount { get; }
        public string Info => $"{this.GetType().ToString()} Created: {this.creationDateTime} AnyCount: {this.AnyCount}";
    }
}

