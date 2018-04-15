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
            oneSomeDataEntity=new SomeDataEntity();
            Console.WriteLine( oneSomeDataEntity.Info);

            (string name, int quantity, double pricePerItem) listItem = ("bread flour", 2, 0.99);
            Console.WriteLine($@"name:{listItem.name}  qty:{listItem.quantity} total: £{listItem.quantity * listItem.pricePerItem}");
            
        }
    }

    class SomeDataEntity
    {

        public SomeDataEntity()
        {
        }
        public SomeDataEntity(int anyCount)
        {
            this.AnyCount = anyCount;
        }

        private DateTime creationDateTime=DateTime.Now;
        public int AnyCount { get; } = -1;
        public string Info => $"{this.GetType().ToString()} Created: {this.creationDateTime} AnyCount: {this.AnyCount}";
    }
}

